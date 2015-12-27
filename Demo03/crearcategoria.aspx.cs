using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Demo03
{
    public partial class crearcategoria : System.Web.UI.Page
    {
        private string cadena = "Server=(local); DataBase=bd_web; user=sa; Password=BaseDeDatos2015";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            using(SqlConnection conex= new SqlConnection(cadena))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("insert into categoria(nombre) values(@p1)",conex))
                {
                    cmd.Parameters.AddWithValue("@p1", this.txtNombre.Text);
                    bool result = cmd.ExecuteNonQuery()==1;
                    if (result)
                    {
                        //Mensaje de grabado cone exito
                        Response.Redirect("Inicio.aspx");
                    }
                    else
                    {
                        //Mensaje de error
                    }
                }
            }
        }
       

    }
}