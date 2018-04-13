using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySwift.Startup))]
namespace MySwift
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
