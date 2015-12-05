using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularwithAsp.Startup))]
namespace AngularwithAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
