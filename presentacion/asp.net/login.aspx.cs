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
    public partial class login : System.Web.UI.Page
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

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=GUTY;" +
                                "Trusted_Connection=yes;" +
                                  "database=BANCODB; " +
                                  "connection timeout=30");

            SqlConnection conexion = acceso_datos.conexion.GetConnection();

            SqlCommand cmd = new SqlCommand("PA_VALIDAR_USUARIO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@user", SqlDbType.VarChar, 20).Value = txbox1.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20).Value = txbox2.Text;
            cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@tipo", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 40).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@cedula", SqlDbType.VarChar,20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@id_cliente", SqlDbType.Int).Direction = ParameterDirection.Output;

            //cmd.Parameters.Add("@pSistema", SqlDbType.VarChar, 20).Value = "19";
            //cmd.Parameters.Add("@pTipoUsr", SqlDbType.VarChar, 5).Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("@pMsg", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("@pNombre", SqlDbType.VarChar, 300).Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("@pError", SqlDbType.Int).Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("@pDepar", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;


            try
            {
                con.Open();
                cmd.ExecuteScalar();
                result = cmd.Parameters["@result"].Value.ToString();
                tipo = cmd.Parameters["@tipo"].Value.ToString();
                nombre=cmd.Parameters["@nombre"].Value.ToString();
                cedula=cmd.Parameters["@cedula"].Value.ToString();
                id_cliente = cmd.Parameters["@id_cliente"].Value.ToString();


                Session.Add("nombre", nombre);
                Session.Add("cedula", cedula);
                Session.Add("id_cliente", id_cliente);
                Session.Add("tipo", tipo);

                if (tipo == "3")
                {
                    Response.Redirect("opciones.aspx", true);
                }

                else if (tipo == "1")
                {
                    Response.Redirect("busqueda.aspx", true);
                }

                //pError = cmd.Parameters["@pError"].Value.ToString();
                //pNombre = cmd.Parameters["@pNombre"].Value.ToString();
                //pMsg = cmd.Parameters["@pMsg"].Value.ToString();
                //pTipoUsr = cmd.Parameters["@pTipoUsr"].Value.ToString();
                //pUsuario = cmd.Parameters["@pUsuario"].Value.ToString();
                //pDepar = cmd.Parameters["@pDepar"].Value.ToString();
            }
            catch (Exception ex)
            {

            }

        
            //SqlConnection myConnection = new SqlConnection("server=GUTY;" +
            //                           "Trusted_Connection=yes;" +
            //                           "database=BANCODB; " +
            //                           "connection timeout=30");


            //myConnection.Open();


            //string checkuser = "select count(*) from BANCODB.dbo.TBLUSUARIO where usuario ='" + txbox1 + "'";
            //SqlCommand com = new SqlCommand(checkuser, myConnection);
            //int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            //myConnection.Close();

            //if (temp == 1)
            //{
            //    myConnection.Open();
            //    string checkPasswordQuery = "select password from BANCODB.dbo.TBLUSUARIO where usuario='" + txbox1 + "'";
            //    SqlCommand passComm = new SqlCommand(checkPasswordQuery, myConnection);
            //    string password = passComm.ExecuteScalar().ToString().Replace(" ", "");
            //    if (password == txbox2.Text)
            //    {
            //        Session["New"] = txbox1.Text;
            //        Response.Write("Password is correct");
            //    }

            //    else
            //    {
            //        Response.Write("Password is not correct");
            //    }

            //}

            //else
            //{
            //    Response.Write("Username is Not Correct");
            //}

            //Server.Transfer("crear_cuentas.aspx", true);


        }

        protected void txbox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}