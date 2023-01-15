using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.Servidor
{
    class ServidorBase: IServidorBase
    {
        //private int codUsuario;
		public DataTable getDados(string sql)
        {
            ConexaoCustomizada ConexaoTemp = new ConexaoCustomizada();
            return ConexaoTemp.RetornaDados(sql);
		}
    }
 
}
