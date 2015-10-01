using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DisenadoresWeb.Startup))]
namespace DisenadoresWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
