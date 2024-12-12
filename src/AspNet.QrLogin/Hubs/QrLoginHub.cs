using Microsoft.AspNetCore.SignalR;

namespace AspNet.QrLogin.Hubs
;

public class QrLoginHub : Hub
{
    public async Task SendAuth(string user, string message)
        => await Clients.All.SendAsync("ReceiveMessage", user, message);

    public async Task ReciveToken(string user, string message)
        => await Clients.All.SendAsync("ReceiveMessage", user, message);
}