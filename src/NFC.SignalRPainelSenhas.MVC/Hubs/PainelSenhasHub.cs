using Microsoft.AspNet.SignalR;

namespace NFC.SignalRPainelSenhas.MVC.Hubs
{
    public class PainelSenhasHub : Hub
    {
        public void InformarSenhaAtual(string guiche, string senha)
        {
            Clients.All.DispararSenhaAtual(guiche,senha);
        }
    }
}