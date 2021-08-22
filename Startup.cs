using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRComDotNetFramework.Startup))]

namespace SignalRComDotNetFramework
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
