using ChinoEsquina.UPC.BE;
using ChinoEsquina.UPC.DA;
using Microsoft.Extensions.Configuration;

namespace ChinoEsquina.UPC.BL
{
    public class DocumentoIdentidadBL
    {
        private readonly DocumentoIdentidadDA objDocumentoIdentidadDA;

        public DocumentoIdentidadBL(IConfiguration configuration)
        {
            objDocumentoIdentidadDA = new DocumentoIdentidadDA(configuration);
        }

        public IEnumerable<DocumentoIdentidad> ListarTodo() {
            return objDocumentoIdentidadDA.ListarTodo();
        }

        public IEnumerable<DocumentoIdentidad> ListarActivo()
        {
            return objDocumentoIdentidadDA.ListarActivo();
        }

        public DocumentoIdentidad BuscarPorId(int IdDocumentoIdentidad)
        {
            return objDocumentoIdentidadDA.BuscarPorId(IdDocumentoIdentidad);
        }

        public DocumentoIdentidad Registrar(DocumentoIdentidad objDocumentoIdentidad)
        {
            return objDocumentoIdentidadDA.Registrar(objDocumentoIdentidad);
        }

        public bool Actualizar(DocumentoIdentidad documentoIdentidad)
        {
            return objDocumentoIdentidadDA.Actualizar(documentoIdentidad);
        }
    }
}