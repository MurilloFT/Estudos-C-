using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Servidor
{
    interface IServidorCadastro
    {
        bool setUsuario(DadosUsuario Usuario);
        DataTable getUsuarios(string Filtro, bool FiltroDataGrid);
        DataTable getProdutos(string Filtro, bool FiltroDataGrid);
        DataTable getClientes(string Filtro, bool FiltroDataGrid);
        DataTable getPedidos(string Filtro, bool FiltroDataGrid);
    }
}
