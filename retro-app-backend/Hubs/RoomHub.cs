using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace retro_app_backend.Hubs
{
    public class RoomHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
