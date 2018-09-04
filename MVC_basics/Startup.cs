using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_basics.Startup))]
namespace MVC_basics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
