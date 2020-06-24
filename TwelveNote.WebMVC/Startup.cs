using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwelveNote.WebMVC.Startup))]
namespace TwelveNote.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
