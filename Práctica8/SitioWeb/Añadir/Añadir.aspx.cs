using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected bool FormularioCorrecto
        {
            get
            {
                bool bCorrecto = true;
                // Volvemos a dejar en blanco los comentarios
                et_Nombre.Text = "";
                et_Autor.Text = "";
                et_Archivo.Text = "";
                // Comprobamos el formulario
                if (sa_SubirArchivo.FileName.Length == 0)
                {
                    et_Archivo.Text = "* Error";
                    bCorrecto = false;
                }
                if(ct_Nombre.Text.Length == 0) 
                {
                    et_Nombre.Text = "* Error: Seleccione un nombre!!";
                }
                if (ct_Autor.Text.Length == 0)
                {
                    et_Autor.Text = "* Error: Seleccione un autor!!";
                }
                return bCorrecto;
            }
        }


        protected void bt_Añadir_Click(object sender, EventArgs e)
        {
            if (FormularioCorrecto) 
            {
                // La carpeta raíz del sitio web es "~/"
                string sRutaSitioWeb = Page.Server.MapPath("~/"); // ver documentación de Page.Server
                                                                  // Subimos los archivos al servidor
                sa_SubirArchivo.PostedFile.SaveAs(sRutaSitioWeb + "fotos/" + sa_SubirArchivo.FileName);

                //Guardamos la información en la base de datos
                string foto = "fotos/" + sa_SubirArchivo.FileName;
                string nombre = ct_Nombre.Text;
                string autor = ct_Autor.Text;
                string descripcion = ct_Descripcion.Text;
                if (descripcion.Length == 0)
                    descripcion = "-- Sin Descripción --";
                /*string sconexión = ConfigurationManager.ConnectionStrings["bd_famososConnectionString"].ConnectionString; // ver clase ConfigurationManager
                SqlConnection conexión = new SqlConnection(sconexión);
                string sOrdenSQL = "insert into album (foto, nombre, autor," + " descripcion) values (@FOTO,@NOMBRE,@AUTOR,@DESCRIPCION)";
                SqlCommand ordenSQL = new SqlCommand(sOrdenSQL, conexión);
                ordenSQL.Parameters.AddWithValue("@FOTO", foto);
                ordenSQL.Parameters.AddWithValue("@NOMBRE", nombre);
                ordenSQL.Parameters.AddWithValue("@AUTOR", autor);
                ordenSQL.Parameters.AddWithValue("@DESCRIPCION", descripcion);            
                ordenSQL.Connection.Open();
                ordenSQL.ExecuteNonQuery();
                ordenSQL.Connection.Close();*/

                ServiceReference4.Service1Client servicio = new ServiceReference4.Service1Client();
                servicio.AñadirFoto(foto, nombre, autor, descripcion);


                this.Response.Redirect("../Default.aspx");
            }
        }
    }
}