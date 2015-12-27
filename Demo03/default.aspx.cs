using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Demo03
{
    public partial class _default : System.Web.UI.Page
    {
        string cadena = "server=(local); DataBase=bd_web; User=sa; Password=BaseDeDatos2015";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string mensaje = "alert('Bienvenidos al desarrollo')";
                ClientScriptManager cs = Page.ClientScript;
                cs.RegisterClientScriptBlock(this.GetType(), "mensaje", mensaje, true);
            }
           
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if(validarUsuario(this.txtUsuario.Text,this.txtClave.Text))
                Response.Redirect("inicio.aspx");
            else
            {
                //Mensaje usuario incorrecto!!
            }
        }

        private bool validarUsuario(string usuario, string clave)
        {
            bool result = false;
            using (SqlConnection conex = new SqlConnection(cadena))
            {
                conex.Open();
                using(SqlCommand cmd=new SqlCommand("Select * from usuario where nick=@p1 and clave=@p2",conex))
                {
                    cmd.Parameters.AddWithValue("@p1",usuario);
                    cmd.Parameters.AddWithValue("@p2", clave);
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                    if (reader != null && reader.HasRows)
                        result = true;
                }
            }
            return result;
        }
    }
}