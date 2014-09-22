using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Booker.Startup))]
namespace Booker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
