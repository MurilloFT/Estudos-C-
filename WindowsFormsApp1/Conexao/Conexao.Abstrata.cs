using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class ConexaoAbstrata
    {
        public abstract SqlConnection Conectar();

        public abstract void Desconectar();

    }
}
