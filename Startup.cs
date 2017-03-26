using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyApps.Startup))]
namespace MyApps
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
