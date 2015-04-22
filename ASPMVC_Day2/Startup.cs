using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPMVC_Day2.Startup))]
namespace ASPMVC_Day2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
