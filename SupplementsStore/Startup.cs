using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SupplementsStore.Startup))]
namespace SupplementsStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
