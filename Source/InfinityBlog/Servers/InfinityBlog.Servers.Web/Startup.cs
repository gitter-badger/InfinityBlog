using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InfinityBlog.Servers.Web.Startup))]
namespace InfinityBlog.Servers.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
