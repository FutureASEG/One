using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(One.Web.Startup))]

namespace One.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
