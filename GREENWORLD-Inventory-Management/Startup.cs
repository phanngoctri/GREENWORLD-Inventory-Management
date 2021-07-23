using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GREENWORLD_Inventory_Management.Startup))]
namespace GREENWORLD_Inventory_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
