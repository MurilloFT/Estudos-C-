using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DadosUsuario
    {
        private int id;
        private string usuario;
        private string senha;
        private bool insert;
        private bool update;

        public int Id
        {
            get
            {   
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }
        public string Usuario
        {
            get
            {
                return this.usuario;
            }

            set
            {
                this.usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return this.senha;
            }

            set
            {
                this.senha = value;
            }
        }

        public bool Insert
        {
            get
            {
                return this.insert;
            }

            set
            {
                this.insert = value;
            }
        }

        public bool Update
        {
            get
            {
                return this.update;
            }

            set
            {
                this.update = value;
            }
        }

    }

    class DadosProduto
    {
        private int id;
        private int qtde;
        private string descricao;
        private decimal vl_unitario;
     
        private bool insert;
        private bool update;

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }
        public string Descricao
        {
            get
            {
                return this.descricao;
            }

            set
            {
                this.descricao = value;
            }
        }

        public int Qtde
        {
            get
            {
                return this.qtde;
            }

            set
            {
                this.qtde = value;
            }
        }

        public decimal Vl_unitario
        {
            get
            {
                return this.vl_unitario;
            }

            set
            {
                this.vl_unitario = value;
            }
        }

        public bool Insert
        {
            get
            {
                return this.insert;
            }

            set
            {
                this.insert = value;
            }
        }

        public bool Update
        {
            get
            {
                return this.update;
            }

            set
            {
                this.update = value;
            }
        }

    }

    public class DadosCliente
    {
        private int id;
        private string nome;
        private string cpf_cnpj;
        private string logradouro;
        private string numero;
        private string bairro;

        private bool insert;
        private bool update;

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }
        public string Nome
        {
            get
            {
                return this.nome;
            }

            set
            {
                this.nome = value;
            }
        }

        public string Cpf_cnpj
        {
            get
            {
                return this.cpf_cnpj;
            }

            set
            {
                this.cpf_cnpj = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return this.logradouro;
            }

            set
            {
                this.logradouro = value;
            }
        }

        public string Numero
        {
            get
            {
                return this.numero;
            }

            set
            {
                this.numero = value;
            }
        }

        public string Bairro
        {
            get
            {
                return this.bairro;
            }

            set
            {
                this.bairro = value;
            }
        }

        public bool Insert
        {
            get
            {
                return this.insert;
            }

            set
            {
                this.insert = value;
            }
        }

        public bool Update
        {
            get
            {
                return this.update;
            }

            set
            {
                this.update = value;
            }
        }
    }

    class DadosPedido
    {
        private int id;
        private Decimal vl_total;
        private DadosCliente cliente = new DadosCliente();
        private DadosProduto produto = new DadosProduto();

        private bool insert;
        private bool update;

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }
        public DadosCliente Cliente
        {
            get
            {
                return this.cliente;
            }

            set
            {
                this.cliente = value;
            }
        }

        public DadosProduto Produto
        {
            get
            {
                return this.produto;
            }

            set
            {
                this.produto = value;
            }
        }

        public decimal Vl_Total
        {
            get
            {
                return this.vl_total;
            }

            set
            {
                this.vl_total = value;
            }
        }

        public bool Insert
        {
            get
            {
                return this.insert;
            }

            set
            {
                this.insert = value;
            }
        }

        public bool Update
        {
            get
            {
                return this.update;
            }

            set
            {
                this.update = value;
            }
        }
    }
}
