using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPersonalWebApp.Startup))]
namespace MyPersonalWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
