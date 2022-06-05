using ChinoEsquina.UPC.BE;
using ChinoEsquina.UPC.DA;
using ChinoEsquina.UPC.EF;

namespace ChinoEsquina.UPC.BL
{
    public class DocumentoIdentidadBL
    {
        private readonly DocumentoIdentidadDA objDocumentoIdentidadDA;

        public DocumentoIdentidadBL()
        {
            objDocumentoIdentidadDA = new DocumentoIdentidadDA();
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

        public DocumentoIdentidad Modificar(DocumentoIdentidad documentoIdentidad)
        {
            return objDocumentoIdentidadDA.Modificar(documentoIdentidad);
        }
    }
}