using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zuni.FrontEnd.Startup))]
namespace Zuni.FrontEnd
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
