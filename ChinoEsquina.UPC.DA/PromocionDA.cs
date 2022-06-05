using ChinoEsquina.UPC.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.DA
{
    public class PromocionDA
    {
        private readonly dbChinoEsquinaContext dc;

        public PromocionDA()
        {
            dc = new dbChinoEsquinaContext();
        }

        public Promocion Buscar(int IdPromocion)
        {
            return dc.Promocions.Where(x => x.IdPromocion.Equals(IdPromocion)).Single();
        }

        public Promocion Registrar(Promocion objPromocion)
        {
            objPromocion.FechaRegistro = DateTime.Now;
            dc.Promocions.Add(objPromocion);
            dc.SaveChanges();
            return objPromocion;
        }

        public Promocion Modifcar(Promocion objPromocion)
        {
            var promocion = dc.Promocions.Where(x => x.IdPromocion.Equals(objPromocion.IdPromocion)).Single();
            promocion.Nombre = objPromocion.Nombre;
            promocion.Descripcion = objPromocion.Descripcion;
            promocion.FechaInicio = objPromocion.FechaInicio;
            promocion.FechaFinal = objPromocion.FechaFinal;
            promocion.Activo = objPromocion.Activo;
            promocion.IdUsuarioModifico = objPromocion.IdUsuarioModifico;
            promocion.FechaModifico = DateTime.Now;
            dc.SaveChanges();
            return promocion;
        }

        public bool Eliminar(int IdPromocion)
        {
            dc.Promocions.Remove(dc.Promocions.Where(x => x.IdPromocion.Equals(IdPromocion)).Single());
            dc.SaveChanges();

            return true;
        }

        public IEnumerable<Promocion> ListarTodo()
        {
            return dc.Promocions;
        }
    }
}
