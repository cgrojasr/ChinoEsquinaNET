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

        public IEnumerable<DocumentoIdentidad> ListarTodo() { 
            return dc.DocumentoIdentidads;
        }

        public IEnumerable<DocumentoIdentidad> ListarActivo()
        {
            return dc.DocumentoIdentidads.Where(x=>x.Activo.Equals(true));
        }

        public DocumentoIdentidad BuscarPorId(int IdDocumentoIdentidad)
        {
            return dc.DocumentoIdentidads.Where(x => x.IdDocumentoIdentidad.Equals(IdDocumentoIdentidad)).Single();
        }

        public DocumentoIdentidad Registrar(DocumentoIdentidad objDocumentoIdentidad)
        {
            objDocumentoIdentidad.FechaRegistro = DateTime.Now;
            dc.Add(objDocumentoIdentidad);
            dc.SaveChanges();
            return objDocumentoIdentidad;
        }

        public DocumentoIdentidad Modificar(DocumentoIdentidad documentoIdentidad)
        {
            var objDocumentoIdentidad = dc.DocumentoIdentidads.Where(x => x.IdDocumentoIdentidad.Equals(documentoIdentidad.IdDocumentoIdentidad)).Single();
            objDocumentoIdentidad.Nombre = documentoIdentidad.Nombre;
            objDocumentoIdentidad.Abreviatura = documentoIdentidad.Abreviatura;
            objDocumentoIdentidad.FechaModifico = DateTime.Now;
            objDocumentoIdentidad.IdUsuarioModifico = documentoIdentidad.IdUsuarioModifico;
            dc.SaveChanges();
            return objDocumentoIdentidad;
        }
    }
}