using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CherryPicking.Startup))]
namespace CherryPicking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
