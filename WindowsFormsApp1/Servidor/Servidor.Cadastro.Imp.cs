using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Servidor
{
    class ServidorCadastro:IServidorCadastro
    {
        DataTable Dt = new DataTable();
        ConexaoCustomizada ConexaoTemp = new ConexaoCustomizada();
        string sql = string.Empty;

        public bool setUsuario(DadosUsuario Usuario)
        {
            if (Usuario.Insert)
            {
                sql = " INSERT INTO USUARIO(NOME, SENHA, DH_INCLUSAO) " +
                      " VALUES  ('"+Usuario.Usuario+"', '"+Usuario.Senha+"', CURRENT_TIMESTAMP) ";
            }
            else
            {
                sql = " UPDATE USUARIO SET NOME  = '"+Usuario.Usuario+"',                         " +
                      "                    SENHA = '"+Usuario.Senha+"',                           " +
                      "                    DH_INCLUSAO = CURRENT_TIMESTAMP                        " +
                      " WHERE COD_USUARIO =@CodUsuario                                            ";
            }

            return ConexaoTemp.ExecutaComando(sql);
        }

        public DataTable getUsuarios(string Filtro, bool FiltroDataGrid)
        {
                   sql =  " SELECT U.COD_USUARIO,                                     " +
                          "        U.NOME,                                            " +
                          "        U.SENHA,                                           " +
                          "        U.DH_INCLUSAO                                      " +
                          "   FROM USUARIO U                                          " +
                          " LEFT JOIN PESSOA P                                        " +
                          " ON U.COD_PESSOA = P.COD_PESSOA                            ";

            if (FiltroDataGrid)
            {
                sql = sql + " WHERE U.NOME LIKE '%" + Filtro + "%' ";
            }
            else
            {
                if (Filtro != string.Empty)
                {
                    sql = sql + "WHERE U.COD_USUARIO = " + Filtro;
                }
            }

            return ConexaoTemp.RetornaDados(sql);

        }

        public DataTable getProdutos(string Filtro, bool FiltroDataGrid)
        {

                   sql = " SELECT COD_PRODUTO,              " +
                         "        DESCRICAO,                " +
                         "        VL_UNITARIO,              " +
                         "        DH_INCLUSAO               " +
                         " FROM PRODUTO ";

            if (FiltroDataGrid)
            {
                sql = sql + " WHERE DESCRICAO LIKE '%" + Filtro + "%' ";
            }
            else
            {
                if (Filtro != string.Empty)
                {
                    sql = sql + "WHERE COD_PRODUTO = " + Filtro;
                }
            }
            return ConexaoTemp.RetornaDados(sql);
        }

        public DataTable getClientes(string Filtro, bool FiltroDataGrid)
        {
                   sql = " SELECT COD_CLIENTE,              " +
                         "        NOME,                     " +
                         "        ENDERECO,                 " +
                         "        CPF_CNPJ,                 " +
                         "        DH_INCLUSAO,              " +
                         "        NUMERO,                   " +
                         "        BAIRRO                    " +
                         " FROM CLIENTE ";

            if (FiltroDataGrid)
            {
                sql = sql + " WHERE NOME LIKE '%" + Filtro + "%' ";
            }
            else
            {
                if (Filtro != string.Empty)
                {
                    sql = sql + "WHERE COD_CLIENTE = " + Filtro;
                }
            }
            return ConexaoTemp.RetornaDados(sql);
        }

        public DataTable getPedidos(string Filtro, bool FiltroDataGrid)
        {
                   sql = " SELECT P.COD_PEDIDO,               " +
                         "        P.COD_CLIENTE,              " +
                         "        PP.COD_PRODUTO,             " +
                         "        PR.DESCRICAO,               " +
                         "        PP.VL_UNITARIO,             " +
                         "        PP.QTDE,                    " +
                         "        (PP.QTDE * PP.VL_UNITARIO), " +
                         "        C.NOME,                     " +
                         "        P.DH_INCLUSAO               " +
                         " FROM PEDIDO P                      " +
                         " INNER JOIN CLIENTE C               " +
                         "   ON C.COD_CLIENTE = P.COD_CLIENTE " +
                         " INNER JOIN PRODUTO_PEDIDO PP       " +
                         "   ON PP.COD_PEDIDO = P.COD_PEDIDO  " +
                         " INNER JOIN PRODUTO PR              " +
                         "   ON PR.COD_PRODUTO = PP.COD_PRODUTO ";

            if (FiltroDataGrid)
            {
                sql = sql + " WHERE C.NOME LIKE '%" + Filtro + "%' ";
            }
            else
            {
                if (Filtro != string.Empty)
                {
                    sql = sql + "WHERE P.COD_PEDIDO = " + Filtro;
                }
            }
            return ConexaoTemp.RetornaDados(sql);
        }
    }
}
