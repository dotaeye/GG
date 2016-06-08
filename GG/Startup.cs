using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GG.Startup))]
namespace GG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
