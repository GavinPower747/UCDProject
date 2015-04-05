using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeTuts.Web.Startup))]
namespace CodeTuts.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
