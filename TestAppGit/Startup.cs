using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppGit.Startup))]
namespace TestAppGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
