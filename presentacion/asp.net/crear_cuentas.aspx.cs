using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;
using System.Data.SqlClient;
using acceso_datos;

namespace presentacion.asp.net
{
    public partial class crear_cuentas : System.Web.UI.Page
    {

        private string User;
        private string pass;
        private string result;
        private string tipo;
        private string nombre;
        private string cedula;
        private string id_cliente;
        private int temp;

        protected void Page_Load(object sender, EventArgs e)
        {
            //conexion MyController = new conexion();
            string nombre = (string)(Session["nombre"]);
            string cedula = (string)(Session["cedula"]);
            string temp = (string)(Session["id_cliente"]);


            label1.Text = nombre;
            label2.Text = cedula;
          
        }

        protected void button5_Click(object sender, EventArgs e)
        {
            if (seleccion_cuenta1.Value.ToString() == "Ahorro")
            {
                SqlConnection con = new SqlConnection("server=GUTY;" +
                               "Trusted_Connection=yes;" +
                                 "database=BANCODB; " +
                                 "connection timeout=30");


                SqlCommand cmd = new SqlCommand("PA_CREAR_CUENTA_AHORRO", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@tipo", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 40).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@cedula", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@id_cliente", SqlDbType.Int).Direction = ParameterDirection.Output;


                try
                {
                    con.Open();
                    cmd.ExecuteScalar();
                    result = cmd.Parameters["@result"].Value.ToString();
                    tipo = cmd.Parameters["@tipo"].Value.ToString();
                    nombre = cmd.Parameters["@nombre"].Value.ToString();
                    cedula = cmd.Parameters["@cedula"].Value.ToString();
                    id_cliente = cmd.Parameters["@id_cliente"].Value.ToString();

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}