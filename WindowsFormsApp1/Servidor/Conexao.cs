using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Servidor
{
     class ConexaoCustomizada: CustomConexao
    {
        private CustomConexao FConexao;
        private string FParametros = string.Empty;

        public ConexaoCustomizada()
        {
            FParametros = @"Data Source=DESKTOP-BGFD6VQ\SQLEXPRESS;Initial Catalog=DADOS_LOJA1;Integrated Security=True";
            FConexao = new ConexaoSqlServer(FParametros);
        }

        public override bool ExecutaComando(string sql)
        {
            return FConexao.ExecutaComando(sql);
        }

        public override DataTable RetornaDados(string sql)
        {
            return FConexao.RetornaDados(sql);
        }

        public override bool ValidaDados(String sql)
        {
            return FConexao.ValidaDados(sql);
        }
    }
}
