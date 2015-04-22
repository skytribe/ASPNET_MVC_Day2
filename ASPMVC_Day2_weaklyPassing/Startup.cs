using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPMVC_Day2_PassingData.Startup))]
namespace ASPMVC_Day2_PassingData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
