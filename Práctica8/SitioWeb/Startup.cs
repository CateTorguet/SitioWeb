using Microsoft.Owin;
using Owin;
using SitioWeb.Models;

[assembly: OwinStartupAttribute(typeof(SitioWeb.Startup))]
namespace SitioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ApplicationRole rolAdmin = null;
            if (!ApplicationRole.FindRole("Administradores")) 
            {
                rolAdmin = ApplicationRole.CreateRole("Administradores");
            }
            // Crear un usuario y añadirlo al rol "Administradores".
            var user = ApplicationUser.CreateUser("admin@uah.es", "admin.p8");
            if (user != null)
            {
                // Escriba aquí la línea de código que añada
                // el usuario "user" al rol "rolAdmin".
                user.AddUserToRole(rolAdmin);
            }

        }
    }
}
