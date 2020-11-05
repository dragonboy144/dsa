using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DSAHeldenTool.Startup))]
namespace DSAHeldenTool
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
