using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc5bootstrap.Startup))]
namespace mvc5bootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
