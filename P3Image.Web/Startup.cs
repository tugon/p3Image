using Microsoft.Owin;
using Owin;
using P3Image.Web;

[assembly: OwinStartup(typeof(Startup))]

namespace P3Image.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}