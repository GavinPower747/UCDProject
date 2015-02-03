using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeTuts.Startup))]
namespace CodeTuts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
