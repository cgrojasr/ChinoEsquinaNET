using ChinoEsquina.UPC.BE;
using ChinoEsquina.UPC.DA.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ChinoEsquina.UPC.DA
{
    public class DocumentoIdentidadDA : IDocumentoIdentidadDA
    {
        private readonly IDbConnection db;

        public DocumentoIdentidadDA(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public bool Actualizar(DocumentoIdentidad obj)
        {
            throw new NotImplementedException();
        }

        public DocumentoIdentidad BuscarPorId(int id)
        {
            return db.QuerySingle<DocumentoIdentidad>($"SELECT * FROM documento_identidad WHERE id_documento_identidad = {id}");
        }

        public IEnumerable<DocumentoIdentidad> ListarTodo()
        {
            return db.Query<DocumentoIdentidad>("SELECT * FROM documento_identidad");
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DocumentoIdentidad> ListarActivo()
        {
            throw new NotImplementedException();
        }

        public DocumentoIdentidad Registrar(DocumentoIdentidad obj)
        {
            throw new NotImplementedException();
        }
    }
}