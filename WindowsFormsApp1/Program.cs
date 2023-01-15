using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        { 
          frmLogin frm = new frmLogin();

          if (frm.ShowDialog() == DialogResult.OK)
          {
            Application.Run(new frmPrincipal());
          }
        }
    }
}
