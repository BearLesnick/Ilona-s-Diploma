using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectWithAuthorization.Startup))]
namespace ProjectWithAuthorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
