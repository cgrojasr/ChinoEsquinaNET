using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.Entity
{
    public class Promocion : AuditoriaData
    {
        public int id_promocion { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_final { get; set; }
    }
}
