using ChinoEsquina.UPC.BL;
using ChinoEsquina.UPC.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.UT
{
    [TestClass]
    public class PromocionUT
    {
        private readonly PromocionBL objPromocionBL;

        public PromocionUT()
        {
            objPromocionBL = new PromocionBL();
        }

        [TestMethod]
        public void Registrar()
        {
            var promocion = new Promocion { 
                Nombre = "Nuevo 2",
                Descripcion = "Nuevo 2",
                FechaInicio = DateTime.Now,
                FechaFinal = DateTime.Now,
                IdUsuarioRegistro = 0,
                Activo = true,
                Eliminado = false
            };
            var response = objPromocionBL.Registrar(promocion);
            Assert.AreEqual(1, response.IdPromocion);
        }

        [TestMethod]
        public void Modificar()
        {
            var promocion = new Promocion
            {
                IdPromocion = 1,
                Nombre = "Modificado",
                Descripcion = "Modificado",
                FechaInicio = DateTime.Now,
                FechaFinal = DateTime.Now,
                IdUsuarioModifico = 0,
                Activo = true,
                Eliminado = false
            };
            var response = objPromocionBL.Modifcar(promocion);
            Assert.AreEqual("Modificado", response.Nombre);
        }

        [TestMethod]
        public void Buscar()
        {
            var promocion = objPromocionBL.Buscar(1);
            Assert.AreEqual(1, promocion.IdPromocion);
        }

        [TestMethod]
        public void ListarTodo()
        {
            var promocion = objPromocionBL.ListarTodo();
            Assert.AreEqual(2, promocion.Count());
        }

        [TestMethod]
        public void Eliminar()
        {
            var result = objPromocionBL.Eliminar(2);
            Assert.AreEqual(true, result);
        }
    }
}
