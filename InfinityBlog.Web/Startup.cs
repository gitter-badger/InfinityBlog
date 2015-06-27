using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InfinityBlog.Web.Startup))]
namespace InfinityBlog.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
