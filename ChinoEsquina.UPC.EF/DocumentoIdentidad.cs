using System;
using System.Collections.Generic;

namespace ChinoEsquina.UPC.EF
{
    public partial class DocumentoIdentidad
    {
        public DocumentoIdentidad()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int IdDocumentoIdentidad { get; set; }
        public string Nombre { get; set; } = null!;
        public string Abreviatura { get; set; } = null!;
        public bool Activo { get; set; }
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioModifico { get; set; }
        public DateTime? FechaModifico { get; set; }
        public bool Eliminado { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
