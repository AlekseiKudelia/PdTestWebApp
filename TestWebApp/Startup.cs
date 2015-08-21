using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute("TestWebAppStartup", typeof(TestWebApp.Startup))]
namespace TestWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
