
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Fiap.Estrutura.Repository
{
    public class UsuarioRepository
    {
        private readonly string _connectionString = "User Id=xx;Password=xx;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";


        public bool validarLogin(string usuario, string senha)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            {
                string query = "select count(1) from usuarios_FIAP where nomeusuario='" + usuario + "' and senha ='" + senha + "'";

                connection.Open();

                OracleCommand cmd = new OracleCommand(query, connection);

                object resultado = cmd.ExecuteScalar();

                if(Convert.ToInt32(resultado) == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            return false;
        }
    }
}
