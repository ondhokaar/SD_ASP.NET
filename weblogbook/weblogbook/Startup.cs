using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(weblogbook.Startup))]
namespace weblogbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
