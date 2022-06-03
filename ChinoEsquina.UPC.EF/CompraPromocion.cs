using System;
using System.Collections.Generic;

namespace ChinoEsquina.UPC.EF
{
    public partial class CompraPromocion
    {
        public int IdCompra { get; set; }
        public int IdPromocion { get; set; }
        public int Puntos { get; set; }
        public bool Activo { get; set; }
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioModifico { get; set; }
        public DateTime? FechaModifico { get; set; }
        public bool Eliminado { get; set; }

        public virtual Compra IdCompraNavigation { get; set; } = null!;
        public virtual Promocion IdPromocionNavigation { get; set; } = null!;
    }
}
