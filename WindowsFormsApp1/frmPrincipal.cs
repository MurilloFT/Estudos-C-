using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {

        private Form ObjForm;

        bool FecharMenu;

        public frmPrincipal()
        {
            InitializeComponent();
            FecharMenu = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ObjForm != null)
            {
                ObjForm.Close();
                ObjForm = null;
            }

            ObjForm = new frmBaseCadastro
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };

            pnlCadastros.Controls.Add(ObjForm);
            ObjForm.Show();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(97, 55, 21);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (ObjForm != null)
            {
                ObjForm.Close();
                ObjForm = null;
            }

            ObjForm = new frmCadastrarProduto
            {
                TopLevel = false,
                Dock = DockStyle.Fill

            };

            pnlCadastros.Controls.Add(ObjForm);
            ObjForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FecharMenu = !(FecharMenu);

            if (FecharMenu)
            {
                pnlMenu.Width = 43;
                btnAcoes.Text    = string.Empty;
                btnUsuario.Text  = string.Empty;
                btnPedidos.Text  = string.Empty;
                btnProdutos.Text = string.Empty;
                btnClientes.Text = string.Empty;
            }
            else
            {
                pnlMenu.Width    = 164;
                btnAcoes.Text    = "Ações";
                btnUsuario.Text  = "Usuários";
                btnPedidos.Text  = "Pedidos";
                btnProdutos.Text = "Produtos";
                btnClientes.Text = "Clientes";
            }

        }

        private void btnProdutos_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(240, 118, 118);
        }

        private void btnProdutos_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(39, 39, 49);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (ObjForm != null)
            {
                ObjForm.Close();
                ObjForm  = null;
            }

            ObjForm = new frmCadastroCliente()
             {
                TopLevel = false,
                Dock     = DockStyle.Fill

            };

            pnlCadastros.Controls.Add(ObjForm);
            ObjForm.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            if (ObjForm != null)
            {
                ObjForm.Close();
                ObjForm = null;
            }

            ObjForm = new frmPedidos
            {
                TopLevel = false,
                Dock = DockStyle.Fill

            };

            pnlCadastros.Controls.Add(ObjForm);
            ObjForm.Show();

        }

        private void frmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            Funcoes.MouseDown(this, e);
        }
    }
}
