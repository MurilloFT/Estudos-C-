using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastroCliente : Form
    {
        string CodigoCliente;
        bool Edicao;
        public CadastroCliente(string CodigoCli, bool Edicao)
        {
            InitializeComponent();
            CodigoCliente = CodigoCli;
            Edicao = Edicao;

            if (Edicao == true)
            {
                CarregarDados();
            }
        }

        private void CarregarDados()
        {
       
            DataTable Dt = Servidores.ServidorCadastro.getClientes(string.Empty, false);

            if (Dt != null)
            {
                txbNome.Text = Dt.Rows[0]["Cliente"].ToString();
                txbNumero.Text = Dt.Rows[0]["NUMERO"].ToString();
                txbLogradouro.Text = Dt.Rows[0]["Logradouro"].ToString();
                txbCpf.Text = Dt.Rows[0]["CPF_CNPJ"].ToString();
                txbBairro.Text = Dt.Rows[0]["BAIRRO"].ToString();

                Dt = null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txbNome.Text != string.Empty) & (txbLogradouro.Text != string.Empty))
            {
                Cadastro Cadastrar = new Cadastro();
                DadosCliente Cliente = new DadosCliente();
                
                Cliente.Nome = txbNome.Text;
                Cliente.Cpf_cnpj = txbCpf.Text;
                Cliente.Logradouro = txbLogradouro.Text;
                Cliente.Numero = txbNumero.Text;
                Cliente.Bairro = txbBairro.Text;

                if (Edicao) { Cliente.Update = Edicao; Cliente.Id = Int32.Parse(CodigoCliente); }
                else { Cliente.Insert = !(Edicao); }

                bool Cadastrou = Cadastrar.Cliente(Cliente);

                if (Cadastrou)
                {
                    MessageBox.Show("Cadastro realizado com sucesso.");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Funcoes.MouseDown(this, e);
        }
    }
}
