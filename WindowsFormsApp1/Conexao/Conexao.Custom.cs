using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class CustomConexao
    { 
        public abstract bool ExecutaComando(string sql);

        public abstract DataTable RetornaDados(string sql);

        public abstract bool ValidaDados(string sql);


    }
}
