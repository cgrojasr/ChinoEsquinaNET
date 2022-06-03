using System;
using System.Collections.Generic;

namespace ChinoEsquina.UPC.EF
{
    public partial class Promocion
    {
        public Promocion()
        {
            CompraPromocions = new HashSet<CompraPromocion>();
        }

        public int IdPromocion { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public bool Activo { get; set; }
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioModifico { get; set; }
        public DateTime? FechaModifico { get; set; }
        public bool Eliminado { get; set; }

        public virtual ICollection<CompraPromocion> CompraPromocions { get; set; }
    }
}
