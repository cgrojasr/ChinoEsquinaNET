using System;
using System.Collections.Generic;

namespace ChinoEsquina.UPC.EF
{
    public partial class Cliente
    {
        public Cliente()
        {
            Compras = new HashSet<Compra>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int IdDocumentoIdentidad { get; set; }
        public string NroDocumento { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Activo { get; set; }
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioModifico { get; set; }
        public DateTime? FechaModifico { get; set; }
        public bool Eliminado { get; set; }

        public virtual DocumentoIdentidad IdDocumentoIdentidadNavigation { get; set; } = null!;
        public virtual ICollection<Compra> Compras { get; set; }
    }
}
