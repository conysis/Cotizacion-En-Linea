using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cotizacion_En_Linea.Startup))]
namespace Cotizacion_En_Linea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
