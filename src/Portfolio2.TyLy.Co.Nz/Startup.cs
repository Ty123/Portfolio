using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portfolio2.TyLy.Co.Nz.Startup))]
namespace Portfolio2.TyLy.Co.Nz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
