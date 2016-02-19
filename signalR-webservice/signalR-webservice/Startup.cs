using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(signalR_webservice.Startup))]
namespace signalR_webservice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
