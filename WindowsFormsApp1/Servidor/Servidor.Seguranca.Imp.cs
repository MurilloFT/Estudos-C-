using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Servidor
{
    class ServidorSeguranca : IServidorSeguranca
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Dados;
        //private int codUsuario;
        public bool VerificaLogin(String Usuario, String Senha)
        {
            string sql = " SELECT NOME,               " +
                         "        SENHA               " +
                         "   FROM USUARIO             " +
                         " WHERE NOME = '"+Usuario+"' " +
                         "  AND SENHA = '"+Senha+"'   ";
            ConexaoCustomizada ConexaoTemp = new ConexaoCustomizada();
            return ConexaoTemp.ValidaDados(sql);
        }

    }
}
