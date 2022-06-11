using ChinoEsquina.UPC.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChinoEsquina.UPC.API.Controllers
{
    [Route("api/documentoidentidad")]
    [ApiController]
    public class DocumentoIdentidadController : ControllerBase
    {
        private readonly DocumentoIdentidadBL objDocumentoIdentidadBL;

        public DocumentoIdentidadController(IConfiguration configuration)
        {
            objDocumentoIdentidadBL = new DocumentoIdentidadBL(configuration);
        }

        [HttpGet]
        public IActionResult ListarTodo() {
            return Ok(objDocumentoIdentidadBL.ListarTodo());
        }

        [HttpGet("activo")]
        public IActionResult ListarActivo()
        {
            return Ok(objDocumentoIdentidadBL.ListarActivo());
        }
    }
}
