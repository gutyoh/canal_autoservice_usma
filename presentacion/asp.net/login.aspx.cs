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
using System.Windows.Forms;


namespace presentacion.asp.net
{
    public partial class login : System.Web.UI.Page
    {
      
        private int temp;
        string connStr = ConfigurationManager.ConnectionStrings["conexionBANCODB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
           acceso_datos.conexion conexion = new acceso_datos.conexion();
            conexion.Opass = txbox2.Text;
            conexion.Ouser = txbox1.Text;
            conexion.login();           
                
                if (conexion.Otipo == "3")
                {
                    Response.Redirect("opciones.aspx", false);
                     Session.Add("nombre",conexion.Onombre);
                    Session.Add("cedula", conexion.Ocedula);
                    Session.Add("id_cliente", conexion.Oid_cliente);
                    Session.Add("tipo", conexion.Otipo);
                }

                else if (conexion.Otipo == "1")
                {
                    Response.Redirect("busqueda.aspx", false);
                }

                else if (conexion.Otipo == "")
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", "MENSAJE DE ALERTA");
                  
                }

                
            }
          
  
        }

    }
