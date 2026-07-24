using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


internal class Conexion
    {
        public static SqlConnection obtenerConexion()
        {
            SqlConnection cn = new SqlConnection(
               "Server=localhost;Database=Orquideas2;Trusted_Connection=True;Encrypt=False;"
            );

            return cn;
        }

    }

