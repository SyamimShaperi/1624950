using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BadmintonShop.co.Startup))]
namespace BadmintonShop.co
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
