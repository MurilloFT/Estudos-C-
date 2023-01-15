using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Cadastro:SetDados
    {
        public bool Usuario(DadosUsuario Usuario)
        {
            string sql = string.Empty;

            if (Usuario.Insert)
            {
               sql = " INSERT INTO USUARIO(NOME, SENHA, DH_INCLUSAO) " +
                     " VALUES  (@Usuario, @Senha, CURRENT_TIMESTAMP) ";
            }
            else
            {
                sql = " UPDATE USUARIO SET NOME  = @Usuario,                                      " +
                      "                    SENHA = @Senha,                                        " +
                      "                    DH_INCLUSAO = CURRENT_TIMESTAMP                        " +
                      " WHERE COD_USUARIO =@CodUsuario                                            " ;
            }

            return setDadosUsuario(sql, Usuario);
        }

        public bool Produto(DadosProduto Produto)
        {
            string sql = string.Empty;

            if (Produto.Insert)
            {
                sql = " INSERT INTO PRODUTO(DESCRICAO, VL_UNITARIO, DH_INCLUSAO) " +
                      " VALUES  (@Descricao, @Unitario, CURRENT_TIMESTAMP) ";
            }
            else
            {
                sql = " UPDATE PRODUTO SET DESCRICAO   = @Descricao,                              " +
                      "                    VL_UNITARIO = @Unitario,                               " +
                      "                    DH_INCLUSAO = CURRENT_TIMESTAMP                        " +
                      " WHERE COD_PRODUTO = @CodProduto                                           ";
            }

            return setDadosProduto(sql, Produto);
        }

        public bool Cliente(DadosCliente Cliente)
        {
            string sql = string.Empty;

            if (Cliente.Insert)
            {
                sql = " INSERT INTO CLIENTE(NOME, ENDERECO, BAIRRO, NUMERO, CPF_CNPJ, DH_INCLUSAO) " +
                      " VALUES  (@Nome, @Endereco, @Bairro, @Numero, @CpfCnpj, CURRENT_TIMESTAMP) ";
            }
            else
            {
                sql = " UPDATE CLIENTE SET NOME     = @Nome,                                      " +
                      "                    ENDERECO = @Endereco,                                  " +
                      "                    BAIRRO   = @Bairro,                                    " +
                      "                    NUMERO      =@Numero,                                  " +
                      "                    DH_INCLUSAO = CURRENT_TIMESTAMP                        " +
                      " WHERE COD_PRODUTO = @CodProduto                                           ";
            }

            return setDadosCliente(sql, Cliente);
        }

        public bool Pedido(DadosPedido Pedido)
        {
            string sql = string.Empty;

            if (Pedido.Insert)
            {
                sql = " INSERT INTO PEDIDO(COD_CLIENTE, DH_INCLUSAO)              " +
                      " VALUES  (@Cliente, CURRENT_TIMESTAMP)  SELECT @@identity  " ;
            }
            else
            {
                sql = " UPDATE CLIENTE SET NOME     = @Nome,                                      " +
                      "                    ENDERECO = @Endereco,                                  " +
                      "                    BAIRRO   = @Bairro,                                    " +
                      "                    NUMERO      =@Numero,                                  " +
                      "                    DH_INCLUSAO = CURRENT_TIMESTAMP                        " +
                      " WHERE COD_PRODUTO = @CodProduto                                           ";
            }

            return setDadosPedido(sql, Pedido);
        }
    }
}
