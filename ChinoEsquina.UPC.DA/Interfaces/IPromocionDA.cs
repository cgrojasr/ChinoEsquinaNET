using ChinoEsquina.UPC.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.DA.Interfaces
{
    public interface IPromocionDA : ICRUD<Promocion>
    {
        IEnumerable<Promocion> ListarPorNombre(String nombre);
        IEnumerable<Promocion> ListarPorDescripcion(String descripcion);
    }
}
