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
    public partial class busqueda : System.Web.UI.Page
    {
        string cedula, result, id_cliente, nombre;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = conexion.GetConnection();

            SqlConnection con = new SqlConnection("server=GUTY;" +
                               "Trusted_Connection=yes;" +
                                 "database=BANCODB; " +
                                 "connection timeout=30");

            SqlCommand cmd = new SqlCommand("PA_BUSCAR_CUENTA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@cedula", SqlDbType.VarChar, 20).Value = txbox_Cedula.Text;
            cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@id_cliente", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 40).Direction = ParameterDirection.Output;

            try
            {
                con.Open();
                cmd.ExecuteScalar();
                result = cmd.Parameters["@result"].Value.ToString();
                id_cliente = cmd.Parameters["@id_cliente"].Value.ToString();
                nombre = cmd.Parameters["@nombre"].Value.ToString();
                cedula = cmd.Parameters["@cedula"].Value.ToString();

            }
            catch (Exception ex)
            {
            }
            if (result == "1")
            {
                Session.Add("id_cliente", id_cliente);
                Session.Add("nombre", nombre);
                Session.Add("cedula", cedula);
                Response.Redirect("opciones.aspx");
                
            }

            else
            {
                   MessageBox.Show("El cliente no existe en el sistema.", "MENSAJE DE ALERTA");
            }
        }
    }
}