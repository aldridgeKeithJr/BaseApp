using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseApp.Startup))]
namespace BaseApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
