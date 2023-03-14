using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHuynhLeVy.Startup))]
namespace NguyenHuynhLeVy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
