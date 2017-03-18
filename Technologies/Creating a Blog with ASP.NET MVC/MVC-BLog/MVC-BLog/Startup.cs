using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_BLog.Startup))]
namespace MVC_BLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
