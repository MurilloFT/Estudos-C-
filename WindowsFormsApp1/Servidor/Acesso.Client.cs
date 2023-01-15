using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Servidor;

namespace WindowsFormsApp1
{
    class Servidores
    {
        public static IServidorBase ServidorBase = new ServidorBase();
        public static IServidorSeguranca ServidorSeguranca = new ServidorSeguranca();
        public static IServidorCadastro ServidorCadastro = new ServidorCadastro();
    }
}
