using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionUsuarios
{
    internal class DBConecction
    {
        private string ConnectionString
            = "Data Source=S08-PC07;Initial Catalog=GestionUsuarios;" +
            "User=sa;Password=123456";

            public SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }

    }
}
