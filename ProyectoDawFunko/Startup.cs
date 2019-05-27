using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoDawFunko.Startup))]
namespace ProyectoDawFunko
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
