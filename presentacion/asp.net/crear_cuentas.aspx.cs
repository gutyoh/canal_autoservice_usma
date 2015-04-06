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


namespace presentacion.asp.net
{
    public partial class crear_cuentas : System.Web.UI.Page
    {

        private string mensaje;
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
               SqlConnection con = new SqlConnection("server=GUTY;" +
                               "Trusted_Connection=yes;" +
                                 "database=BANCODB; " +
                                 "connection timeout=30");

                SqlCommand cmd = new SqlCommand("PA_CREAR_CUENTA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cuenta", SqlDbType.Int).Value = DropDownList1.SelectedValue;
                cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = DropDownList2.SelectedValue;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
               
                try
                {
                    con.Open();
                    cmd.ExecuteScalar();                    
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    con.Close();
                 }
                catch (Exception ex)
                {

                }
                if (mensaje == "")
                {

                }
                else
                {
                    
                }
        }
    }
}