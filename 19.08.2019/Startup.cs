using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_19._08._2019.Startup))]
namespace _19._08._2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
