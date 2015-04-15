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
using System.Windows.Forms;


namespace presentacion.asp.net
{
    public partial class crear_cuentas : System.Web.UI.Page
    {

        private string mensaje;
        private string nombre;
        private string cedula;
        private string id_cliente;
        private int temp;
        private int cuenta_nueva;
        private float balance_nuevo;

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
                cmd.Parameters.Add("@cuenta", SqlDbType.Int).Value = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
                cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue.ToString());
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@cuenta_nueva", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@balance_nuevo", SqlDbType.Float).Direction = ParameterDirection.Output;
               


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

                    Session.Add("nombre", nombre);
                    Session.Add("cedula", cedula);
                    Session.Add("cuenta_nueva", cuenta_nueva);
                    Session.Add("balance_nuevo", balance_nuevo);
                    Session.Add("tipo_cuenta", DropDownList2.SelectedItem.Text);

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
        }
    }
}