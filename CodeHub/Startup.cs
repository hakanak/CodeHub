using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeHub.Startup))]
namespace CodeHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
