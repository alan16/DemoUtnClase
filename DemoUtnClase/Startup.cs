using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoUtnClase.Startup))]
namespace DemoUtnClase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
