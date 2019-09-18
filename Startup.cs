using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftwareDevelopmentDiso.Startup))]
namespace SoftwareDevelopmentDiso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
