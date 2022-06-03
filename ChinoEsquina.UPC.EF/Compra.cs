using System;
using System.Collections.Generic;

namespace ChinoEsquina.UPC.EF
{
    public partial class Compra
    {
        public Compra()
        {
            CompraDetalles = new HashSet<CompraDetalle>();
            CompraPromocions = new HashSet<CompraPromocion>();
        }

        public int IdCompra { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoVenta { get; set; }
        public decimal ValorVenta { get; set; }
        public bool Activo { get; set; }
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioModifico { get; set; }
        public DateTime? FechaModifico { get; set; }
        public bool Eliminado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<CompraDetalle> CompraDetalles { get; set; }
        public virtual ICollection<CompraPromocion> CompraPromocions { get; set; }
    }
}
