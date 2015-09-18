using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AOACollections.Startup))]
namespace AOACollections
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
