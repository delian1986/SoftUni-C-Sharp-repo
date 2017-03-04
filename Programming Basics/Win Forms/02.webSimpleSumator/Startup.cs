using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02.webSimpleSumator.Startup))]
namespace _02.webSimpleSumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
