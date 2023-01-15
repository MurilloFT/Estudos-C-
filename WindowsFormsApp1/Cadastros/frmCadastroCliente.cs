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
    public partial class frmCadastroCliente : Form
    {
        private DadosCliente cliente = new DadosCliente();        
        DataTable Dt = new DataTable();

        bool RetornaValorCliente;

        public frmCadastroCliente()
        {
            InitializeComponent();
            CarregarDados();
        }
        public frmCadastroCliente(bool RetornaCliente)
        {
            InitializeComponent();
            CarregarDados();
            if (RetornaCliente) {
                RetornaValorCliente = true;
                lblCadUsuario.Visible = false;
                lblEdtUsuario.Visible = false;
//                DadosCliente Cliente = new DadosCliente();
            };
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

        private void CoresLinhas()
        {
            for (int i = 0; i <= dgvUsuarios.Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
          //          Color clr = new Color();

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
            if (Dt != null)
            {
                Dt = null;
            }

            Dt = Servidores.ServidorCadastro.getClientes(string.Empty, false);
            dgvUsuarios.DataSource = Dt;
        }

        private void lblCadUsuario_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroCliente(string.Empty, false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void lblEdtUsuario_Click(object sender, EventArgs e)
        {
            String Flag = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            Form frm = new CadastroCliente(Flag, true);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Dt = Servidores.ServidorCadastro.getClientes(string.Empty, false);
            dgvUsuarios.DataSource = Dt;
        }

        private void lblCadUsuario_MouseEnter_1(object sender, EventArgs e)
        {
             this.Cursor = Cursors.Hand;
             (sender as Label).ForeColor = Color.Red;
        }

        private void lblCadUsuario_MouseLeave_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            (sender as Label).ForeColor = Color.White;
        }

        private void lblEdtUsuario_Click_1(object sender, EventArgs e)
        {
            String Flag = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            Form frm = new CadastroCliente(Flag, true);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void dgvUsuarios_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i <= dgvUsuarios.Columns.Count - 1; i++)
            {
                dgvUsuarios.Columns[i].Width = ((this.Width / 4) - 3);
            }

            CoresLinhas();

            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[5].Visible = false;
            dgvUsuarios.Columns[6].Visible = false;
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              //Rows[0]["NUMERO"].ToString();
            Cliente.Nome = dgvUsuarios.CurrentRow.Cells["Cliente"].Value.ToString();
            Cliente.Id = Int32.Parse(dgvUsuarios.CurrentRow.Cells["COD_CLIENTE"].Value.ToString());
            this.DialogResult = DialogResult.OK;

        }
    }
}
