using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication1
{

    public partial class Site1 : System.Web.UI.MasterPage
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnvalidar_Click(object sender, EventArgs e)
        {

            string usuario;
            string clave;

            if
               (Txtusuario.Text != "" && txtcontraseña.Text != "");
            SqlConnection conexion = new SqlConnection(.SqlDataSourcel.ConnectionString);

            usuario = System.Convert.ToString((Txtusuario.Text));
            clave = System.Convert.ToString((txtcontraseña.Text));

            string cadena = "SELECT count(*) FROM usuario WERE nombre_usuario = Gnosbre and clave-éclave";
            SqlCommand consulta_comprobar = new SqlCommand(cadena, conexion);
            
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}