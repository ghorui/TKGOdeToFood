using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TKGOdeToFood.Startup))]
namespace TKGOdeToFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
