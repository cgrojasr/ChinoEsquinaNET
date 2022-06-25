using ChinoEsquina.UPC.BE;
using ChinoEsquina.UPC.DA.Interfaces;
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
    public class ClienteDA : IClienteDA
    {
        private readonly IDbConnection db;

        public ClienteDA(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }


        public bool Actualizar(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public Cliente Registrar(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
