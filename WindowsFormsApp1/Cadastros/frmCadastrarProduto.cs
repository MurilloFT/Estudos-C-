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
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CoresLinhas()
        {
            for (int i = 0; i <= dgvUsuarios.Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    dgvUsuarios.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(33, 35, 45);
                }
                else
                {
                    dgvUsuarios.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(27, 25, 33);
                }

                dgvUsuarios.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 118, 118);
            }
        }

        private void lblCadUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblCadUsuario.ForeColor = Color.White;
        }

        private void lblCadUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblCadUsuario.ForeColor = Color.Red;
        }

        private void lblEdtUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblEdtUsuario.ForeColor = Color.Red;
        }

        private void lblEdtUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblEdtUsuario.ForeColor = Color.White;
        }

        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i <= dgvUsuarios.Columns.Count - 1; i++)
            {
                dgvUsuarios.Columns[i].Width = ((this.Width / 3) - 4);
            }

            CoresLinhas();

            dgvUsuarios.Columns[0].Visible = false;
        }

        private void CarregarDados()
        {
            DataTable Dt = Servidores.ServidorCadastro.getProdutos(string.Empty,false);
            dgvUsuarios.DataSource = Dt;

        }


        private void lblCadUsuario_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroProduto(string.Empty, false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void lblEdtUsuario_Click(object sender, EventArgs e)
        {
            String Flag = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            Form frm = new CadastroProduto(Flag, true);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable Dt = Servidores.ServidorCadastro.getProdutos(textBox1.Text, true);
            dgvUsuarios.DataSource = Dt;
        }
    }
}
