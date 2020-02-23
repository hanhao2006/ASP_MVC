using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectAMT.Startup))]
namespace ProjectAMT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
