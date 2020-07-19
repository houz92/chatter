using System.Threading.Tasks;

namespace Chatter.Backend.Chatter
{
    public interface IChatterHub
    {
        Task SendMessage(ChatMessage message);
    }
}