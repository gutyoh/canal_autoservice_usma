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
    public partial class opciones : System.Web.UI.Page
    {

        private string User;
        private string pass;
        private string result;
        private string tipo;
        private string nombre;
        private string cedula;

        string seleccion;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            string id_cliente = (string)(Session["id_cliente"]);
            string nombre = (string)(Session["nombre"]);
            string tipo = (string)(Session["tipo"]);
            string cedula = (string)(Session["cedula"]);      

            label_nombreCliente.Text = nombre;         
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            seleccion = caja_desplegable.Value.ToString();

            if (seleccion == "Crear Cuentas")
                {
                    Response.Redirect("crear_cuentas.aspx", true);
                }

                else if (seleccion == "Consultas")
                {
                    Response.Redirect("consultas.aspx", true);
                }
        
        }
    }
}