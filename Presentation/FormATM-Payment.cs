﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Common.Cache;
using DataAccess;
using Domain;
using System.Diagnostics;

namespace Presentation
{
    public partial class FormCajeroPago : Form
    {
        public ListView list = new ListView();

        public FormCajeroPago()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            enterFunction();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cancelar el pago?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void ImgPrint_Click(object sender, EventArgs e)
        {
            genFactura(list);
            this.Close();
        }

        public void setStockItems()
        {
            int sId = 0;
            int sQuantity = 0;
            int sStock = 0;
            for (int i = 0; i < list.Items.Count; i++)
            {
                Models oModels = new Models();
                for (int j = 0; j < list.Columns.Count; j++)
                {
                    if (j == 0)
                    {
                        sQuantity = Convert.ToInt32(list.Items[i].SubItems[j].Text);
                    }
                    else if (j == 4)
                    {
                        sId = Convert.ToInt32(list.Items[i].SubItems[j].Text);
                    }
                    else if(j == 5)
                    {
                        sStock = Convert.ToInt32(list.Items[i].SubItems[j].Text);
                    }
                }
                int ope = sStock - sQuantity;
                //Reinicio de valores
                oModels.SetProduct(ope.ToString(), sId.ToString());
                sId = 0;
                sQuantity = 0;
                sStock = 0;
            }
        }

        public void genFactura(ListView list)
        {
            DateTime dateNow = DateTime.Now;
            DataConsult oDataConsult = new DataConsult();
            int numberBillDb = oDataConsult.GetNumberBillsInitial();
            int numberBill = numberBillDb+1;


            string nomFactura = "factura-"+ numberBill + ".pdf";

            //Tamaño de documento dinámico
            int tList = list.Items.Count;
            int tInicial = 360;

            if (tList >= 3)
            {
                tInicial += ((tList-3) * 10);
            }

            // Creamos el documento con el tamaño de página
            Document doc = new Document(new iTextSharp.text.Rectangle(280f, tInicial));
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"D:\facturas\" + nomFactura, FileMode.Create));

            // Selecciona la tipografía del documento
            BaseFont bf = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bf, 8);

            // Le colocamos el título y el autor
            doc.AddTitle("Factura "+ numberBill + " - "+ DataStoreCache.Namestore);
            doc.AddCreator("Ingenieros Uniteistas");

            // Abrir documento
            doc.Open();

            // Encabezado del documento
            Paragraph p1 = new Paragraph(DataStoreCache.Namestore, times);
            p1.Alignment = Element.ALIGN_CENTER;
            doc.Add(p1);
            Paragraph p2 = new Paragraph("NIT: " + DataStoreCache.Nit, times);
            p2.Alignment = Element.ALIGN_CENTER;
            doc.Add(p2);
            Paragraph p3 = new Paragraph(DataStoreCache.Address, times);
            p3.Alignment = Element.ALIGN_CENTER;
            doc.Add(p3);
            Paragraph p4 = new Paragraph("Tel. "+DataStoreCache.Phone, times);
            p4.Alignment = Element.ALIGN_CENTER;
            doc.Add(p4);

            string recibo = "Recibo: "+ numberBill;
            Paragraph P5 = new Paragraph(recibo, times);
            doc.Add(P5);
            Paragraph p6 = new Paragraph("Fecha: " + dateNow, times);
            doc.Add(p6);
            Paragraph seller = new Paragraph("Vendedor: " + UserLoginCache.FirstName, times);
            doc.Add(seller);

            //Salto de línea
            Paragraph sLine = new Paragraph(" ", times);
            doc.Add(sLine);

            //Creamos tabla para los items
            PdfPTable tbItems = new PdfPTable(3);
            tbItems.WidthPercentage = 100;
            float[] tamanos = new float[] { 2.5f, 1f, 1f };
            tbItems.SetWidths(tamanos);

            // Nombre de las columnas
            PdfPCell colItem = new PdfPCell(new Phrase("Item", times));
            colItem.BorderWidth = 0;
            colItem.BorderWidthBottom = 0.75f;
            tbItems.AddCell(colItem);

            PdfPCell clPrecioCant = new PdfPCell(new Phrase("Precio Cant.", times));
            clPrecioCant.BorderWidth = 0;
            clPrecioCant.BorderWidthBottom = 0.75f;
            tbItems.AddCell(clPrecioCant);

            PdfPCell colValor = new PdfPCell(new Phrase("Valor", times));
            colValor.BorderWidth = 0;
            colValor.BorderWidthBottom = 0.75f;
            tbItems.AddCell(colValor);

            //Se inicializa variables vacías
            //y se inicializan los objetos para la lista de items
            string sItems = "";
            string tNombre = "";
            int tCantidad = 0;
            int cantidadDeItems = 0;
            double tPrecio = 0;
            PdfPCell iNombre;
            PdfPCell iPrecio;
            PdfPCell iMul;

            for (int i = 0; i < list.Items.Count; i++)
            {
                for (int j = 0; j < list.Columns.Count; j++)
                {
                    if (j != 2)
                    {
                        if (j == 0)
                        {
                            tCantidad = Convert.ToInt32(list.Items[i].SubItems[j].Text);
                        }
                        else if(j == 1)
                        {
                            tNombre = list.Items[i].SubItems[j].Text;
                        }
                        else if (j == 3)
                        {
                            tPrecio = Convert.ToDouble(list.Items[i].SubItems[j].Text);
                        }
                    }
                }
                // Se añade fila con el nombre
                iNombre = new PdfPCell(new Phrase(tNombre, times));
                iNombre.BorderWidth = 0;

                // Se añade fila con precio y cantidad
                string sCantidad = tCantidad.ToString();
                string sPrecio = tPrecio.ToString();
                string concat = "$" + sPrecio +" x"+sCantidad;
                iPrecio = new PdfPCell(new Phrase(concat, times));
                iPrecio.BorderWidth = 0;

                // Se añade fila con el precio*cantidad
                double mult = tPrecio*tCantidad;
                string sMult = mult.ToString();
                iMul = new PdfPCell(new Phrase(sMult, times));
                iMul.BorderWidth = 0;

                if (i == (list.Items.Count-1))
                {
                    iNombre.BorderWidth = 0;
                    iNombre.BorderWidthBottom = 0.75f;
                    iPrecio.BorderWidth = 0;
                    iPrecio.BorderWidthBottom = 0.75f;
                    iMul.BorderWidth = 0;
                    iMul.BorderWidthBottom = 0.75f;
                    sItems += tNombre + "," + concat + "," + sMult;
                }
                else
                {
                    //Añadir a valiable para serealización
                    sItems += tNombre + "," + concat + "," + sMult + ";";
                }

                tbItems.AddCell(iNombre);
                tbItems.AddCell(iPrecio);
                tbItems.AddCell(iMul);

                //Va sumando la cantidad de items
                cantidadDeItems += tCantidad;

                //Reinicio de valores
                tNombre = "";
                tCantidad = 0;
                tPrecio = 0;
            }
            // Se añade tabla con los items al documento
            doc.Add(tbItems);

            //Salto de línea
            Paragraph sLine1 = new Paragraph(" ", times);
            doc.Add(sLine1);

            //Cantidad de productos
            Paragraph p7 = new Paragraph("# Items: "+ cantidadDeItems.ToString(), times);
            doc.Add(p7);

            //Salto de línea
            Paragraph sLine2 = new Paragraph(" ", times);
            doc.Add(sLine2);

            //Creamos tabla para los items
            PdfPTable tbData = new PdfPTable(2);
            tbData.WidthPercentage = 100;
            float[] tbDataTama = new float[] { 3f, 2f };
            tbData.SetWidths(tbDataTama);

            // Nombre de las columnas
            PdfPCell coldata = new PdfPCell(new Phrase("Total", times));
            coldata.BorderWidth = 0;
            PdfPCell colPrice = new PdfPCell(new Phrase("$"+lblPriceTotal.Text, times));
            colPrice.BorderWidth = 0;
            tbData.AddCell(coldata);
            tbData.AddCell(colPrice);
            PdfPCell coldata1 = new PdfPCell(new Phrase("Entregado: ", times));
            coldata1.BorderWidth = 0;
            PdfPCell colPrice1 = new PdfPCell(new Phrase("$"+txtRecep.Text, times));
            colPrice1.BorderWidth = 0;
            tbData.AddCell(coldata1);
            tbData.AddCell(colPrice1);
            PdfPCell coldata2 = new PdfPCell(new Phrase("Cambio: ", times));
            coldata2.BorderWidth = 0;
            PdfPCell colPrice2 = new PdfPCell(new Phrase("$"+lblChange.Text, times));
            colPrice2.BorderWidth = 0;
            tbData.AddCell(coldata2);
            tbData.AddCell(colPrice2);
            // Se añade tabla de datos
            doc.Add(tbData);

            //Salto de línea
            Paragraph sLine3 = new Paragraph(" ", times);
            doc.Add(sLine3);

            //Parte final de la factura
            Paragraph p8 = new Paragraph("Gracias por tu compra", times);
            p8.Alignment = Element.ALIGN_CENTER;
            doc.Add(p8);
            Paragraph p9 = new Paragraph("Software creado con <3 por universitarios", times);
            p9.Alignment = Element.ALIGN_CENTER;
            doc.Add(p9);
            Paragraph p10 = new Paragraph("UNITEC 2020", times);
            p10.Alignment = Element.ALIGN_CENTER;
            doc.Add(p10);

            doc.Close();
            writer.Close();

            MessageBox.Show("¡Factura generada!");

            //Añadir factura a base de datos
            Models addBill = new Models();
            addBill.AddBill(dateNow.ToShortDateString(), UserLoginCache.FirstName, lblPriceTotal.Text, sItems, lblChange.Text, txtRecep.Text);

            //Abrir factura
            Process p = new Process();
            p.StartInfo.FileName = "D:\\facturas\\" + nomFactura;
            p.Start();
        }

        private void enterFunction()
        {
            int change = Int32.Parse(txtRecep.Text);
            int priceTotal = Int32.Parse(lblPriceTotal.Text);
            lblError.Visible = false;

            if (change >= priceTotal)
            {
                int op = change - priceTotal;
                string sOp = op.ToString();
                lblChange.Text = sOp;

                //Habilitar
                lblChange.Visible = true;
                ImgPrint.Visible = true;

                //Deshabilitar
                btnCloseApp.Visible = false;

                //Actualizar Stock en base de datos
                setStockItems();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void txtRecep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                enterFunction();
            }
        }
    }
}