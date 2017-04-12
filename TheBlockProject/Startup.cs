using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheBlockProject.Startup))]
namespace TheBlockProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
