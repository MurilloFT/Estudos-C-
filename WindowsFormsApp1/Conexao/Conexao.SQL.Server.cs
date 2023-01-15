using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ConexaoSqlServer : CustomConexao
    {
        Conexao Conn = null;
        SqlCommand cmd = new SqlCommand();

        DataTable Aux = new DataTable();
        private string FParametros = string.Empty;
        public ConexaoSqlServer(string AParametros)
        {
            FParametros = AParametros;
            Conn = new Conexao(FParametros);
        }

        public override bool ExecutaComando(string sql)
        {
            Aux.Clear();

            try
            {
                cmd.Connection = Conn.Conectar();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            cmd.Dispose();
            Conn.Desconectar();
            return true;
        }

        public override DataTable RetornaDados(string sql)
        {
      
            Aux.Clear();

            try
            {
                cmd.Connection = Conn.Conectar();
                SqlDataAdapter DadosGrid = new SqlDataAdapter(sql, cmd.Connection);
                DadosGrid.Fill(Aux);
                
                DadosGrid.Dispose();
                cmd.Dispose();
                Conn.Desconectar();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            return Aux;
        }

        public override bool ValidaDados(String sql)
        {
            bool Coincidem = false;
            cmd.CommandText = sql;

            try
            {
                cmd.Connection = Conn.Conectar();
                SqlDataReader Dados = cmd.ExecuteReader();
                if (Dados.HasRows)
                {
                    Coincidem = true;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            cmd.Dispose();
            Conn.Desconectar();
            return Coincidem;
        }

    }
}
