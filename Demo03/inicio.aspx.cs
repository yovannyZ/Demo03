using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo03
{
    public partial class inicio : System.Web.UI.Page
    {
        private string cadena = "Server=(local); DataBase=bd_web; user=sa; Password=BaseDeDatos2015";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            using (SqlConnection conex = new SqlConnection(cadena))
            {
                using (SqlCommand cmd = new SqlCommand("select * from categoria", conex))
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tabla =new DataTable();
                    adaptador.Fill(tabla);
                    this.GridView1.DataSource = tabla;
                    this.GridView1.DataBind();
                }
            }
        }
    }
}