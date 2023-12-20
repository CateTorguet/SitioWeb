using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb
{
    public partial class borrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Obtener la cadena de conexión del archivo de configuración
                string sconexión = ConfigurationManager.ConnectionStrings["bd_famososConnectionString"].ConnectionString;
                // Consulta SQL para obtener los nombres de las fotos y sus valores correspondientes desde la tabla álbum
                string sOrdenSQL = "SELECT foto, nombre FROM album";

                using (SqlConnection conexión = new SqlConnection(sconexión))
                {
                    SqlCommand ordenSQL = new SqlCommand(sOrdenSQL, conexión);
                    conexión.Open();
                    SqlDataReader reader = ordenSQL.ExecuteReader();

                    // Comprobar si hay filas devueltas
                    if (reader.HasRows)
                    {
                        // Recorrer las filas y agregar elementos al ListBox
                        while (reader.Read())
                        {
                            string nombreFoto = reader["nombre"].ToString();
                            string valorFoto = reader["foto"].ToString();
                            bool elementoExistente = false;
                            foreach (ListItem item in ls_Nombres.Items)
                            {
                                if (item.Value == valorFoto)
                                {
                                    elementoExistente = true;
                                    break;
                                }
                            }
                            if (!elementoExistente)
                            {
                                ls_Nombres.Items.Add(new ListItem(nombreFoto, valorFoto));
                            }
                        }
                    }
                    // Cerrar la conexión y el lector de datos
                    reader.Close();
                    conexión.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*// La carpeta raíz del sitio web es "~/"
            string sRutaSitioWeb = Page.Server.MapPath("~/");
            // Borramos la imagen de la carpeta fotos
            File.Delete(sRutaSitioWeb + ls_Nombres.SelectedValue);
            // Borramos la ruta de la imagen de la base de datos
            string sconexión = ConfigurationManager.ConnectionStrings["bd_famososConnectionString"].ConnectionString;  // ver clase ConfigurationManager
            SqlConnection conexión = new SqlConnection(sconexión);

            string sOrdenSQL = "DELETE from album where foto = @FOTO";
            SqlCommand ordenSQL = new SqlCommand(sOrdenSQL, conexión);

            ordenSQL.Parameters.AddWithValue("@FOTO", ls_Nombres.SelectedValue);
            conexión.Open();
            ordenSQL.ExecuteNonQuery();*/
            ServiceReference4.Service1Client servicio = new ServiceReference4.Service1Client();
            servicio.BorrarFoto(ls_Nombres.SelectedValue);

            this.Response.Redirect("../Default.aspx");

        }

        protected void ls_Nombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            Img.ImageUrl = "../"  + ls_Nombres.SelectedValue;
            Console.WriteLine("Aqui esta la ruta"+"../" + ls_Nombres.SelectedValue);
        }
    }
}