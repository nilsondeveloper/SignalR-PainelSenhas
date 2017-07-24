using Microsoft.Owin;
using NFC.SignalRPainelSenhas.MVC;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace NFC.SignalRPainelSenhas.MVC
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
