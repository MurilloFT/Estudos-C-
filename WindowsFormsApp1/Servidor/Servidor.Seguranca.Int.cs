using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal interface IServidorSeguranca
    {
        bool VerificaLogin(String Usuario, String Senha);
    }
}
