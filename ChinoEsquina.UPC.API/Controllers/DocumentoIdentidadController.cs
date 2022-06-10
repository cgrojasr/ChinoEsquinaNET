using AutoMapper;
using AutoMapper.QueryableExtensions;
using ChinoEsquina.UPC.API.Models;
using ChinoEsquina.UPC.BL;
using ChinoEsquina.UPC.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChinoEsquina.UPC.API.Controllers
{
    [Route("api/documentoidentidad")]
    [ApiController]
    public class DocumentoIdentidadController : ControllerBase
    {
        private readonly DocumentoIdentidadBL objDocumentoIdentidadBL;
        private readonly DocumentoIdentidadBLDP objDocumentoIdentidadBLDP;
        private readonly IMapper _mapper;

        public DocumentoIdentidadController(IMapper mapper, IConfiguration _configuration)
        {
            objDocumentoIdentidadBL = new DocumentoIdentidadBL();
            objDocumentoIdentidadBLDP = new DocumentoIdentidadBLDP(_configuration);
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListarTodo() {
            return Ok(objDocumentoIdentidadBLDP.ListarTodo());
            //return Ok(_mapper.Map<IEnumerable<DocumentoIdentidadModel>>(objDocumentoIdentidadBL.ListarTodo()));
        }

        [HttpGet("activo")]
        public IActionResult ListarActivo()
        {
            return Ok(_mapper.Map<IEnumerable<DocumentoIdentidadModel>>(objDocumentoIdentidadBL.ListarActivo()));
        }
    }
}
