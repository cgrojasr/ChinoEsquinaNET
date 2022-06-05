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
        private readonly IMapper _mapper;

        public DocumentoIdentidadController(IMapper mapper)
        {
            objDocumentoIdentidadBL = new DocumentoIdentidadBL();
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListarTodo() {
            return Ok(_mapper.Map<IEnumerable<DocumentoIdentidadModel>>(objDocumentoIdentidadBL.ListarTodo()));
        }

        [HttpGet("activo")]
        public IActionResult ListarActivo()
        {
            return Ok(_mapper.Map<IEnumerable<DocumentoIdentidadModel>>(objDocumentoIdentidadBL.ListarActivo()));
        }
    }
}
