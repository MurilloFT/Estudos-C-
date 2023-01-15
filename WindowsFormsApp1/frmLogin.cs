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
using WindowsFormsApp1.Servidor;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        bool Logado = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((tbUsuario.Text == string.Empty) || (tbSenha.Text == string.Empty)) 
            {
                MessageBox.Show(" Preencha todos os campos para realizar o Login.");
            }
            else
            {  
                if (Servidores.ServidorSeguranca.VerificaLogin(tbUsuario.Text, tbSenha.Text))
                {    
                    DialogResult = System.Windows.Forms.DialogResult.OK;  
                }
                else
                {
                    MessageBox.Show("Informações não coincidem.");
                }
            }
        }

        private void frmLogin_MouseDown_1(object sender, MouseEventArgs e)
        {
            Funcoes.MouseDown(sender, e);
        }

    }
}
