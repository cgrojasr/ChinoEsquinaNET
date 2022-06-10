using ChinoEsquina.UPC.DP.Interfaces;
using ChinoEsquina.UPC.Entity;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.DP.Repositories
{
    public class DocumentoIdentidadRepository : IDocumentoIdentidadRepository
    {
        private readonly IDbConnection db;
        public DocumentoIdentidadRepository(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public List<DocumentoIdentidad> ListarTodo()
        {
            return db.Query<DocumentoIdentidad>("SELECT id_documento_identidad, nombre, abreviatura FROM documento_identidad").ToList();
        }
    }
}
