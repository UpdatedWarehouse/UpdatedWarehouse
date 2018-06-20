using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UpdatedWarehouse.Startup))]
namespace UpdatedWarehouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
