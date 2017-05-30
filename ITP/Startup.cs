using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITP.Startup))]
namespace ITP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
