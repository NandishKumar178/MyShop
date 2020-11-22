using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mycart.WebUI.Startup))]
namespace Mycart.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
