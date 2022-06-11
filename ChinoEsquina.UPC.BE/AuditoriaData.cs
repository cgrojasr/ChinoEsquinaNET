using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.BE
{
    public class AuditoriaData
    {
        public bool activo { get; set; }
        public int id_usuario_registro { get; set; }
        public DateTime fecha_registro { get; set; }
        public int id_usuario_modifico { get; set; }
        public DateTime fecha_modifico { get; set; }
        public bool eliminado { get; set; }
    }
}
