using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Chatter.Backend.Chatter
{
    public class ChatterHub: Hub<IChatterHub>
    {
    }
}