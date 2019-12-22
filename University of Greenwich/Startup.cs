using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(University_of_Greenwich.Startup))]
namespace University_of_Greenwich
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
