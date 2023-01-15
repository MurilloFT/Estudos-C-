using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class CadastroProduto : Form
    {
        string CodigoProduto;
        bool Edicao = false;
        public CadastroProduto(string CodProduto, bool Editar)
        {
            InitializeComponent();
            CodigoProduto = CodProduto;
            Edicao = Editar;
            if (Edicao == true)
            {
                CarregarDados();
            }
        }

        private void CarregarDados()
        {
            DataTable Dt = Servidores.ServidorCadastro.getProdutos(CodigoProduto,false);

            if (Dt != null)
            {
                txbDesc.Text = Dt.Rows[0]["Descrição"].ToString();
                txtPreco.Text = Dt.Rows[0]["Unitário"].ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro   = new Cadastro();
            DadosProduto Produto = new DadosProduto();
            Produto.Descricao   = txbDesc.Text;
            Produto.Vl_unitario = System.Convert.ToDecimal(txtPreco.Text);
            if (Edicao) { Produto.Update = Edicao; Produto.Id = Int32.Parse(CodigoProduto); }
            else { Produto.Insert = !(Edicao); }
            bool Cadastrou = Cadastro.Produto(Produto);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)) && (!(e.KeyChar == (char)8)))
            {
                e.Handled = true;
            };
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Funcoes.MouseDown(this, e);
        }
    }
}
