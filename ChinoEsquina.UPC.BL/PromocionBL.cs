using ChinoEsquina.UPC.DA;
using ChinoEsquina.UPC.EF;
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

        public PromocionBL()
        {
            objPromocionDA = new PromocionDA();
        }

        public Promocion Buscar(int IdPromocion)
        {
            return objPromocionDA.Buscar(IdPromocion);
        }

        public Promocion Registrar(Promocion objPromocion)
        {
            return objPromocionDA.Registrar(objPromocion);
        }

        public Promocion Modifcar(Promocion objPromocion)
        {
            return objPromocionDA.Modifcar(objPromocion);
        }

        public bool Eliminar(int IdPromocion)
        {
            return objPromocionDA.Eliminar(IdPromocion);
        }

        public IEnumerable<Promocion> ListarTodo()
        {
            return objPromocionDA.ListarTodo();
        }
    }
}
