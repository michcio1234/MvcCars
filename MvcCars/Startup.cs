using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCars.Startup))]
namespace MvcCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
