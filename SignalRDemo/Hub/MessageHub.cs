namespace SignalRDemo.Hub;

using Microsoft.AspNetCore.SignalR;

public class MessageHub : Hub<IMessageHubClient>
{
    public async Task SendOffersToUser(List<string> message)
    {
        await Clients.All.SendOffersToUser(message);
    }
}