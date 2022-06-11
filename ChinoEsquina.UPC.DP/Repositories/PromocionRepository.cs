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
    public class PromocionRepository : IPromocionRepository
    {
        private readonly IDbConnection db;
        public PromocionRepository(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public Promocion BuscarPorId(int idPromocion)
        {
            return db.Query<Promocion>($"SELECT * FROM Promocion WHERE id_Promocion = {idPromocion}").Single();
        }

        public IEnumerable<Promocion> ListarTodo()
        {
            return db.Query<Promocion>("SELECT id_promocion, nombre, descripcion FROM Promocion");
        }

        public Promocion Registrar(Promocion objPromocion)
        {
            var id= db.QuerySingle<int>($"INSERT INTO promocion VALUES ('{objPromocion.nombre}', '{objPromocion.descripcion}', " +
                $"'{objPromocion.fecha_inicio}', '{objPromocion.fecha_final}', '{objPromocion.activo}', {objPromocion.id_usuario_registro}, " +
                $"'{DateTime.Now}', NULL, NULL, '{objPromocion.eliminado}'); SELECT CAST(SCOPE_IDENTITY() AS int)");

            objPromocion.id_promocion = id;
            return objPromocion;
        }
    }
}
