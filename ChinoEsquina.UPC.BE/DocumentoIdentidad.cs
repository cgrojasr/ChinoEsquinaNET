using System.ComponentModel.DataAnnotations.Schema;

namespace ChinoEsquina.UPC.BE
{
    public class DocumentoIdentidad : AuditoriaData
    {
        public int id_documento_identidad { get; set; }
        public string nombre { get; set; }
        public string abreviatura { get; set; }
    }
}