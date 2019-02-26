using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appHeroeMVC.Presentacion.Startup))]
namespace appHeroeMVC.Presentacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
