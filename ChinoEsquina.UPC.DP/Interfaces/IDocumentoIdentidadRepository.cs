using ChinoEsquina.UPC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.DP.Interfaces
{
    public interface IDocumentoIdentidadRepository
    {
        List<DocumentoIdentidad> ListarTodo();
    }
}
