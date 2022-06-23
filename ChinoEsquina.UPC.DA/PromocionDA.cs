using ChinoEsquina.UPC.BE;
using ChinoEsquina.UPC.DA.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinoEsquina.UPC.DA
{
    public class PromocionDA : IPromocionDA
    {
        private readonly IDbConnection db;

        public PromocionDA(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public bool Actualizar(Promocion obj)
        {
            var query = @"UPDATE promocion SET nombre = @nombre, descripcion = @descripcion, " +
                "fecha_inicio = @fecha_inicio, fecha_final = @fecha_final, activo = @activo, " +
                "id_usuario_modifico = @id_usuario_modifico, fecha_modifico = GETDATE(), eliminado = @eliminado " +
                "WHERE id_promocion = @id_promocion";
            db.Execute(query, obj);

            return true;
        }

        public Promocion BuscarPorId(int id)
        {
            var query = @"SELECT * FROM promocion WHERE id_promocion = @id_promocion";
            return db.QuerySingle<Promocion>(query, new { id_promocion = id });
        }

        public bool Eliminar(int id)
        {
            var query = @"DELETE FROM promocion WHERE id_promocion = @id_promocion";
            db.Execute(query, new { id_promocion = id });
            return true;
        }

        public IEnumerable<Promocion> ListarPorNombre(string nombre)
        {
            var query = @"SELECT * FROM promocion WHERE nombre LIKE @name";            
            return db.Query<Promocion>(query, new { name = "%" + nombre + "%" });
        }

        public IEnumerable<Promocion> ListarPorDescripcion(string descripcion)
        {
            var query = @"SELECT * FROM promocion WHERE descripcion LIKE @description";
            return db.Query<Promocion>(query, new { description = "%" + descripcion + "%" });
        }

        public IEnumerable<Promocion> ListarTodo()
        {
            var query = "SELECT * FROM promocion";
            return db.Query<Promocion>(query);
        }

        public Promocion Registrar(Promocion obj)
        {
            obj.fecha_registro = DateTime.Now;
            var query = @"INSERT promocion VALUES (@nombre, @descripcion, @fecha_inicio, @fecha_final," +
                "@activo, @id_usuario_registro, @fecha_registro, NULL, NULL, @eliminado); " + 
                "SELECT CAST(SCOPE_IDENTITY() AS int)";
            obj.id_promocion = db.ExecuteScalar<int>(query, obj);
            return obj;
        }
    }
}
