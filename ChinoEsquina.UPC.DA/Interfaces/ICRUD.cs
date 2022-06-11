using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.DA.Interfaces
{
    public interface ICRUD<T>
    {
        T BuscarPorId(int id);
        IEnumerable<T> ListarTodo();
        T Registrar(T obj);
        bool Actualizar(T obj);
        bool Eliminar(int id);
    }
}
