using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSY.Startup))]
namespace MSY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
