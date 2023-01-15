using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Funcoes
    {
        public static void MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            if (sender is Form) { SendMessage((sender as Form).Handle, 0x112, 0xf012, 0); }
            else {SendMessage((sender as Panel).Handle, 0x112, 0xf012, 0);}
        }

        public static void MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(39, 39, 49);
        }

        public static void MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(240, 118, 118);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
