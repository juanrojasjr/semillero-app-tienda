//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentation.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int IdProduct { get; set; }
        public string Ref { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<int> CanMin { get; set; }
        public Nullable<int> PriceProv { get; set; }
        public Nullable<int> PriceSale { get; set; }
    }
}
