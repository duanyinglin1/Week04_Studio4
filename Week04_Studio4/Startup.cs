using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week04_Studio4.Startup))]
namespace Week04_Studio4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
