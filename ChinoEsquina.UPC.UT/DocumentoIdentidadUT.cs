using ChinoEsquina.UPC.BL;

namespace ChinoEsquina.UPC.UT
{
    [TestClass]
    public class DocumentoIdentidadUT
    {
        private readonly DocumentoIdentidadBL objDocumentoIdentidadBL;
        public DocumentoIdentidadUT()
        {
            objDocumentoIdentidadBL = new DocumentoIdentidadBL(null);
        }

        [TestMethod]
        public void ListarTodo()
        {
            var lst = objDocumentoIdentidadBL.ListarTodo();
            Assert.AreEqual(2, lst.Count());
        }
    }
}