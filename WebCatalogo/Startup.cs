using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCatalogo.Startup))]
namespace WebCatalogo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
