using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo.c5_transversal.excepcion;

namespace Modelo.c4_persistencia.sqlserver
{
    public class ConexionSqlServer : GestorODBC
    {
        public override void abrirConexion()
        {
            try
            {
                string url = "data source=Hacybeyker;initial catalog=paginaweb3;persist security info=True;user id=sa;password=123;MultipleActiveResultSets=True;";
                conexion = new SqlConnection(url);
                conexion.Open();
            }
            catch (Exception)
            {
                throw ExcepcionSQL.crearErrorAbrirConexion(); ;
            }
        }
    }
}
