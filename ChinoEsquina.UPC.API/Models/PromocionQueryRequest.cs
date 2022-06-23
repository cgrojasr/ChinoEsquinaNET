namespace ChinoEsquina.UPC.API.Models
{
    public class PromocionQueryRequest
    {
        public PromocionQueryRequest()
        {
            nombre = string.Empty;
            descripcion = string.Empty;
        }

        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
