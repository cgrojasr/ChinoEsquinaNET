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

        public IEnumerable<DocumentoIdentidad> FindAll() {
            return objDocumentoIdentidadDA.FindAll();
        }
    }
}