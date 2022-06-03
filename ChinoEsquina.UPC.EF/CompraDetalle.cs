using System;
using System.Collections.Generic;

namespace ChinoEsquina.UPC.EF
{
    public partial class CompraDetalle
    {
        public int IdCompraDetalle { get; set; }
        public int IdCompra { get; set; }
        public int IdProductoVenta { get; set; }
        public decimal ValorVenta { get; set; }
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioModifico { get; set; }
        public DateTime? FechaModifico { get; set; }
        public bool Eliminado { get; set; }

        public virtual Compra IdCompraNavigation { get; set; } = null!;
    }
}
