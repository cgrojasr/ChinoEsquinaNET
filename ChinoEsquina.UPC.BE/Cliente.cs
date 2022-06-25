using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.BE
{
    public class Cliente : AuditoriaData
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int id_documento_identidad { get; set; }
        public string nro_documento { get; set; }
        public string email { get; set; }
    }
}
