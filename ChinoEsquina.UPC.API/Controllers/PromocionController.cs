using ChinoEsquina.UPC.API.Models;
using ChinoEsquina.UPC.BE;
using ChinoEsquina.UPC.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChinoEsquina.UPC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocionController : ControllerBase
    {
        private readonly PromocionBL objPromocionBL;
        public PromocionController(IConfiguration configuration)
        {
            objPromocionBL = new PromocionBL(configuration);
        }

        [HttpGet]
        public IActionResult Listar([FromQuery] PromocionQueryRequest promocionQueryRequest)
        {
            try
            {
                var result = objPromocionBL.Listar(promocionQueryRequest.nombre, promocionQueryRequest.descripcion);
                if(result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception)   
            {
                return BadRequest();
            }
            
        }

        [HttpGet("{id_promocion}")]
        public IActionResult BuscarPorId(int id_promocion)
        {
            try
            {
                return Ok(objPromocionBL.BuscarPorId(id_promocion));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Registrar(Promocion objPromocionET)
        {
            try
            {
                return Ok(objPromocionBL.Registrar(objPromocionET));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Actualizar(Promocion objPromocion)
        {
            try
            {
                return Ok(objPromocionBL.Actualizar(objPromocion));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id_promocion}")]
        public IActionResult Eliminar(int id_promocion)
        {
            try
            {
                return Ok(objPromocionBL.Eliminar(id_promocion));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
