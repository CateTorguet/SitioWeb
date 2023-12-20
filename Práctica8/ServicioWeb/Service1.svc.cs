using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI;

namespace ServicioWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public void BorrarFoto(string foto)
        {
            // Borramos la ruta de la imagen de la base de datos
            string sconexión = ConfigurationManager.ConnectionStrings["bd_famososConnectionString"].ConnectionString;  // ver clase ConfigurationManager
            SqlConnection conexión = new SqlConnection(sconexión);

            string sOrdenSQL = "DELETE from album where foto = @FOTO";
            SqlCommand ordenSQL = new SqlCommand(sOrdenSQL, conexión);

            ordenSQL.Parameters.AddWithValue("@FOTO", foto);
            conexión.Open();
            ordenSQL.ExecuteNonQuery();
        }

        public void AñadirFoto(string foto, string nombre, string autor, string descripcion)
        {
            // Añadimos una entrada en la base de datos tal y como lo
            // hacíamos en el sitio web
            string sconexión = ConfigurationManager.ConnectionStrings["bd_famososConnectionString"].ConnectionString; // ver clase ConfigurationManager
            SqlConnection conexión = new SqlConnection(sconexión);
            string sOrdenSQL = "INSERT INTO album (foto, nombre, autor," + " descripcion) values (@FOTO,@NOMBRE,@AUTOR,@DESCRIPCION)";
            SqlCommand ordenSQL = new SqlCommand(sOrdenSQL, conexión);
            ordenSQL.Parameters.AddWithValue("@FOTO", foto);
            ordenSQL.Parameters.AddWithValue("@NOMBRE", nombre);
            ordenSQL.Parameters.AddWithValue("@AUTOR", autor);
            ordenSQL.Parameters.AddWithValue("@DESCRIPCION", descripcion);
            conexión.Open();
            ordenSQL.ExecuteNonQuery();
        }
    }
}
