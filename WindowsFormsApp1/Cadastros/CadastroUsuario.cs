using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastroUsuario : Form
    {
        string CodigoUsuario;
        bool Edicao;
        public CadastroUsuario(string CodUsuario,bool Editar)
        {
            InitializeComponent();
            CodigoUsuario = CodUsuario;
            Edicao        = Editar;
            if (Edicao == true) {
                CarregarDados();
            }
        }

        private void CarregarDados()
        {
            DataTable Dt = Servidores.ServidorCadastro.getUsuarios(CodigoUsuario,false);

            if (Dt != null)
            {
                txbUsuario.Text = Dt.Rows[0]["Usuário"].ToString();
                txbSenha.Text   = Dt.Rows[0]["Senha"].ToString();

                Dt = null;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ((txbUsuario.Text != string.Empty) & (txbSenha.Text != string.Empty))
            { 
                DadosUsuario Usuario = new DadosUsuario();
                Usuario.Usuario = txbUsuario.Text;
                Usuario.Senha   = txbSenha.Text;

                if (Edicao) {Usuario.Update = Edicao;Usuario.Id = Int32.Parse(CodigoUsuario); }
                else {Usuario.Insert = !(Edicao);}
                
                if (Servidores.ServidorCadastro.setUsuario(Usuario))
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
