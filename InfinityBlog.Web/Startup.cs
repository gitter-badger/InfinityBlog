[assembly: Microsoft.Owin.OwinStartupAttribute(typeof(InfinityBlog.Web.Startup))]

namespace InfinityBlog.Web
{
    using Microsoft.Owin;
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
