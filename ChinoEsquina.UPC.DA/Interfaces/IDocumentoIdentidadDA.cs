using ChinoEsquina.UPC.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.DA.Interfaces
{
    public interface IDocumentoIdentidadDA : ICRUD<DocumentoIdentidad>
    {
        IEnumerable<DocumentoIdentidad> ListarActivo();
    }
}
