using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BravoProject.Startup))]
namespace BravoProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
