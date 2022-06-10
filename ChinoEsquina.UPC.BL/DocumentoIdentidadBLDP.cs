using ChinoEsquina.UPC.DP.Interfaces;
using ChinoEsquina.UPC.DP.Repositories;
using ChinoEsquina.UPC.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.BL
{
    public class DocumentoIdentidadBLDP
    {
        private readonly DocumentoIdentidadRepository objDocumentoIdentidadDP;
        public DocumentoIdentidadBLDP(IConfiguration _configuration)
        {
            objDocumentoIdentidadDP = new DocumentoIdentidadRepository(_configuration);
        }

        public List<DocumentoIdentidad> ListarTodo()
        {
            return objDocumentoIdentidadDP.ListarTodo();
        }
    }
}
