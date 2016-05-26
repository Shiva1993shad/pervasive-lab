using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(azmayeshgah.Startup))]
namespace azmayeshgah
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
