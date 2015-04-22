using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalcWebApp.Startup))]
namespace CalcWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
