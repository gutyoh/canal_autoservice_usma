using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace presentacion.asp.net
{
    public partial class consultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = (string)(Session["nombre"]);
            string cedula = (string)(Session["cedula"]);
            string id_cliente = (string)(Session["id_cliente"]);

            label_Nombre.Text = nombre;
            label_Cedula.Text = cedula;

        }
    }
}