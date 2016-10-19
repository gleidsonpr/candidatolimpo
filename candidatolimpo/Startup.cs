using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(candidatolimpo.Startup))]
namespace candidatolimpo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
