using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nankivell_MIS4200.Startup))]
namespace Nankivell_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
