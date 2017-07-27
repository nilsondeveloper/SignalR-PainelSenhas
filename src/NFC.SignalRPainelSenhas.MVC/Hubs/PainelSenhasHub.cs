using Microsoft.AspNet.SignalR;

namespace NFC.SignalRPainelSenhas.MVC.Hubs
{
    public class PainelSenhasHub : Hub
    {
        public void InformarSenhaAtual(string guinche, string senha)
        {
            Clients.All.DispararSenhaAtual(guinche,senha);
        }
    }
}