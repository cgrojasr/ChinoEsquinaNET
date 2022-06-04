using ChinoEsquina.UPC.EF;

namespace ChinoEsquina.UPC.DA
{
    public class DocumentoIdentidadDA
    {
        private readonly dbChinoEsquinaContext dc;

        public DocumentoIdentidadDA()
        {
            dc = new dbChinoEsquinaContext();
        }

        public IEnumerable<DocumentoIdentidad> FindAll() { 
            return dc.DocumentoIdentidads.ToList();
        }
    }
}