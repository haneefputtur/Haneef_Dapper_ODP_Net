using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Haneef_Dapper_ODP.Startup))]
namespace Haneef_Dapper_ODP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
