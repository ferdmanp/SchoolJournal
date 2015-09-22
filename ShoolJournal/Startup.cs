using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoolJournal.Startup))]
namespace ShoolJournal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
