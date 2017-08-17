using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InsuranceApolicyWeb.Startup))]
namespace InsuranceApolicyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
