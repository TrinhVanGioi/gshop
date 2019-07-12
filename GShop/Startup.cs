using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GShop.Startup))]
namespace GShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
