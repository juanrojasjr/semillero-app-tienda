using Domain;
using System;
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
using System.Diagnostics;

namespace Presentation
{
    public partial class FormBuys : Form
    {
        Models oBillsF = new Models();
        public FormBuys()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (!txtNumberBill.Text.Trim().Equals(""))
            {
                dataGridView1.DataSource = oBillsF.GetBill(txtNumberBill.Text, dateStart.Value.ToShortDateString(), dateEnd.Value.ToShortDateString(), 0);
            }
            else
            {
                dataGridView1.DataSource = oBillsF.GetBill(txtNumberBill.Text, dateStart.Value.ToShortDateString(), dateEnd.Value.ToShortDateString(), 1);
            }

            if (dataGridView1.RowCount > 1)
            {
                dataGridView1.CurrentCell = null;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                genFactura(dataGridView1.CurrentRow.Cells["IdBill"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["Date"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["Seller"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["PriceTotal"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["Products"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["PriceChange"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["PriceRecep"].Value.ToString());
            }
            else
                MessageBox.Show("Selecciona una fila");
        }

        public void genFactura(String idBill, string date, string sellerInt, string priceTotal, string rlist, string PriceChange, string PriceRecep)
        {
            string nomFactura = "factura-" + idBill + ".pdf";

            //Tamaño de documento dinámico
            int tList = rlist.Length;
            int tInicial = 360;

            if (tList >= 3)
            {
                tInicial += ((tList - 3) * 10);
            }

            // Creamos el documento con el tamaño de página
            Document doc = new Document(new iTextSharp.text.Rectangle(280f, tInicial));
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"D:\facturas\" + nomFactura, FileMode.Create));

            // Selecciona la tipografía del documento
            BaseFont bf = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bf, 8);

            // Le colocamos el título y el autor
            doc.AddTitle("Factura " + idBill + " - " + DataStoreCache.Namestore);
            doc.AddCreator("Ingenieros Uniteistas");

            // Abrir documento
            doc.Open();

            // Encabezado del documento
            Paragraph p1 = new Paragraph(DataStoreCache.Namestore, times);
            p1.Alignment = Element.ALIGN_CENTER;
            doc.Add(p1);
            Paragraph p2 = new Paragraph("NIT: " + "901.177.291-5", times);
            p2.Alignment = Element.ALIGN_CENTER;
            doc.Add(p2);
            Paragraph p3 = new Paragraph(DataStoreCache.Address, times);
            p3.Alignment = Element.ALIGN_CENTER;
            doc.Add(p3);
            Paragraph p4 = new Paragraph("Tel. " + DataStoreCache.Phone, times);
            p4.Alignment = Element.ALIGN_CENTER;
            doc.Add(p4);

            string recibo = "Recibo: " + idBill;
            Paragraph P5 = new Paragraph(recibo, times);
            doc.Add(P5);
            Paragraph p6 = new Paragraph("Fecha: " + date, times);
            doc.Add(p6);
            Paragraph seller = new Paragraph("Vendedor: " + sellerInt, times);
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
            string tNombre = "";
            string tCantidad = "";
            string tPrecio = "";
            PdfPCell iNombre;
            PdfPCell iPrecio;
            PdfPCell iMul;

            //Separa productos por ;
            var products = rlist.Split(';');

            for (int i = 0; i < products.Length; i++)
            {
                //Separa por ,
                var item = products[i].Split(',');

                for (int j = 0; j < item.Length; j++)
                {
                    if (j == 0)
                    {
                        tNombre = item[j];
                    }
                    else if (j == 2)
                    {
                        tCantidad = item[j];
                    }
                    else
                    {
                        tPrecio = item[j];
                    }
                }
                // Se añade fila con el nombre
                iNombre = new PdfPCell(new Phrase(tNombre, times));
                iNombre.BorderWidth = 0;

                // Se añade fila con precio y cantidad
                iPrecio = new PdfPCell(new Phrase(tCantidad, times));
                iPrecio.BorderWidth = 0;

                // Se añade fila con el precio*cantidad
                iMul = new PdfPCell(new Phrase(tPrecio, times));
                iMul.BorderWidth = 0;

                if (i == (products.Length - 1))
                {
                    iNombre.BorderWidth = 0;
                    iNombre.BorderWidthBottom = 0.75f;
                    iPrecio.BorderWidth = 0;
                    iPrecio.BorderWidthBottom = 0.75f;
                    iMul.BorderWidth = 0;
                    iMul.BorderWidthBottom = 0.75f;
                }

                tbItems.AddCell(iNombre);
                tbItems.AddCell(iMul);
                tbItems.AddCell(iPrecio);

                //Reinicio de valores
                tNombre = "";
                tCantidad = "";
                tPrecio = "";
            }
            // Se añade tabla con los items al documento
            doc.Add(tbItems);

            //Salto de línea
            Paragraph sLine1 = new Paragraph(" ", times);
            doc.Add(sLine1);

            //Cantidad de productos
            Paragraph p7 = new Paragraph("# Productos: " + products.Length.ToString(), times);
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
            PdfPCell colPrice = new PdfPCell(new Phrase("$" + priceTotal, times));
            colPrice.BorderWidth = 0;
            tbData.AddCell(coldata);
            tbData.AddCell(colPrice);
            PdfPCell coldata1 = new PdfPCell(new Phrase("Entregado: ", times));
            coldata1.BorderWidth = 0;
            PdfPCell colPrice1 = new PdfPCell(new Phrase("$" + PriceRecep, times));
            colPrice1.BorderWidth = 0;
            tbData.AddCell(coldata1);
            tbData.AddCell(colPrice1);
            PdfPCell coldata2 = new PdfPCell(new Phrase("Cambio: ", times));
            coldata2.BorderWidth = 0;
            PdfPCell colPrice2 = new PdfPCell(new Phrase("$" + PriceChange, times));
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

            //Abrir factura
            Process p = new Process();
            p.StartInfo.FileName = "D:\\facturas\\" + nomFactura;
            p.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormAdmin fAdmin = new FormAdmin();
            fAdmin.Show();
            this.Hide();
        }
    }
}
