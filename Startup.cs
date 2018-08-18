using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TekEngine2018.Startup))]
namespace TekEngine2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
