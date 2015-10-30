using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstGitApp.Startup))]
namespace MyFirstGitApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
