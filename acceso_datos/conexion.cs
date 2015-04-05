using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace acceso_datos
{
    public class conexion
    {
        public static SqlConnection GetConnection()
        {

            SqlConnection con = new SqlConnection("server=GUTY;" +
                                "Trusted_Connection=yes;" +
                                  "database=BANCODB; " +
                                  "connection timeout=30");
            /*con.Open();
            return con;*/

            return con;

        }
       
    }
}