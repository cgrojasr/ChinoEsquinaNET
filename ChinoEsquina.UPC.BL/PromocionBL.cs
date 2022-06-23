using ChinoEsquina.UPC.BE;
using ChinoEsquina.UPC.DA;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.BL
{
    public class PromocionBL
    {
        private readonly PromocionDA objPromocionDA;

        public PromocionBL(IConfiguration configuration)
        {
            objPromocionDA = new PromocionDA(configuration);
        }

        public Promocion BuscarPorId(int idPromocion)
        {
            return objPromocionDA.BuscarPorId(idPromocion);
        }

        public Promocion Registrar(Promocion objPromocion)
        {
            return objPromocionDA.Registrar(objPromocion);
        }

        public bool Actualizar(Promocion objPromocion)
        {
            return objPromocionDA.Actualizar(objPromocion);
        }

        public bool Eliminar(int IdPromocion)
        {
            return objPromocionDA.Eliminar(IdPromocion);
        }

        public IEnumerable<Promocion> Listar(string nombre, string descripcion)
        {
            if(!string.IsNullOrWhiteSpace(nombre))
                return objPromocionDA.ListarPorNombre(nombre);
            else if(!string.IsNullOrWhiteSpace(descripcion))
                return objPromocionDA.ListarPorDescripcion(descripcion);
            else
                return objPromocionDA.ListarTodo();
        }
    }
}
