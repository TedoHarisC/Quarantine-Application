using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aplikasi_Karantina.Startup))]
namespace Aplikasi_Karantina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
