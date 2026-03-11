using Microsoft.AspNetCore.SignalR;

namespace TarasMessanger.Web;

public class ChatHub : Hub
{
    public async Task SendMessage(string senderId, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", senderId, message);
    }
}