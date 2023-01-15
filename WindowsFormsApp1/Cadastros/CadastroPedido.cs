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
    public partial class CadastroPedido : Form
    {
        string CodigoPedido;
        bool Edicao;
        DadosPedido Pedido = new DadosPedido();
        public CadastroPedido(string CodPedido, bool Edicao)
        {
            InitializeComponent();
            pnlCadProduto.Visible = false;
            CodigoPedido = CodPedido;
            Edicao = Edicao;

            if (Edicao == true)
            {
                CarregarDados();
            }
        }

        private void CoresLinhas()
        {
            for (int i = 0; i <= dgvUsuarios.Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Color clr = new Color();

                    dgvUsuarios.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(33, 35, 45);
                }
                else
                {
                    dgvUsuarios.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(27, 25, 33);
                }

                dgvUsuarios.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 118, 118);
            }
        }

        private void CarregarDados()
        {
            DataTable Dt = Servidores.ServidorCadastro.getPedidos(CodigoPedido, false);

            if (Dt != null)
            {
                Pedido.Cliente.Nome = Dt.Rows[0]["Cliente"].ToString();
                Pedido.Cliente.Id   = Int32.Parse(Dt.Rows[0]["COD_CLIENTE"].ToString());
                Pedido.Produto.Id   = Int32.Parse(Dt.Rows[0]["COD_PRODUTO"].ToString());
                Pedido.Produto.Descricao = Dt.Rows[0]["Descrição"].ToString();
                Pedido.Produto.Vl_unitario = System.Convert.ToDecimal(Dt.Rows[0]["Unitário"].ToString());
                Pedido.Produto.Qtde        = Int32.Parse(Dt.Rows[0]["Qtde"].ToString());

                txbCliente.Text = Pedido.Cliente.Nome;

                dgvUsuarios.DataSource = Dt;

                dgvUsuarios.Columns[0].Visible = false;
                dgvUsuarios.Columns[1].Visible = false;
                dgvUsuarios.Columns[2].Visible = false;
                dgvUsuarios.Columns[7].Visible = false;
                dgvUsuarios.Columns[8].Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmCadastroCliente ObjForm = new frmCadastroCliente(true);
            ObjForm.StartPosition = FormStartPosition.CenterScreen;

            if (ObjForm.ShowDialog() == DialogResult.OK)
            {
                Pedido.Cliente = ObjForm.Cliente;
                txbCliente.Text = Pedido.Cliente.Nome;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cadastro cadastros = new Cadastro();
            
            if ((Pedido.Cliente.Nome == null) || (Pedido.Produto.Id == null))
            {

                if (Edicao) { Pedido.Update = Edicao; Pedido.Id = Int32.Parse(CodigoPedido); }
                else { Pedido.Insert = !(Edicao); }

                bool Cadastrou = cadastros.Pedido(Pedido);

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

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            (sender as Label).ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            (sender as Label).ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pnlCadProduto.Visible = true;
            pnlCadProduto.BringToFront();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pnlCadProduto.Visible = false;
            dgvUsuarios.BringToFront();
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

        private void label9_Click(object sender, EventArgs e)
        {
            txbProduto.Text  = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txbUnitario.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txbQtde.Text     = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            pnlCadProduto.Visible = true;
            pnlCadProduto.BringToFront();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Funcoes.MouseDown(this, e);
        }
    }
}
