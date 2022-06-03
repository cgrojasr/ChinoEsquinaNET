using ChinoEsquina.UPC.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChinoEsquina.UPC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentoIdentidadController : ControllerBase
    {
        private readonly DocumentoIdentidadBL objDocumentoIdentidadBL;

        public DocumentoIdentidadController()
        {
            objDocumentoIdentidadBL = new DocumentoIdentidadBL();
        }

        [HttpGet]
        public IActionResult FindAll() {
            return Ok(objDocumentoIdentidadBL.FindAll());
        }
    }
}
