using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Conexao:ConexaoAbstrata
    {
        SqlConnection connection = new SqlConnection();
        public Conexao(string AParametros)
        {
            connection.ConnectionString = AParametros;
        }
  
        public override SqlConnection Conectar()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public override void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
