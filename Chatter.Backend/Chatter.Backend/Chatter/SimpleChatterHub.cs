using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Chatter.Backend.Chatter
{
    public class SimpleChatterHub : ISimpleChatterHub
    {
        private readonly IHubContext<ChatterHub, IChatterHub> context;

        public SimpleChatterHub(IHubContext<ChatterHub, IChatterHub> context)
        {
            this.context = context;
        }

        public async Task SendMessage(string message)
        {
            await context.Clients.All.SendMessage(message.CreateMessage());
        }
    }
}