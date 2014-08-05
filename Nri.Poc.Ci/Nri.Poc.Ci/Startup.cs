using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nri.Poc.Ci.Startup))]
namespace Nri.Poc.Ci
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
