using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(personal_web.Startup))]
namespace personal_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
