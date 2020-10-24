using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1700241_CarRental_MS2.Startup))]
namespace _1700241_CarRental_MS2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
