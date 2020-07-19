using System.Threading.Tasks;

namespace Chatter.Backend.Chatter
{
    public interface ISimpleChatterHub
    {
        Task SendMessage(string message);
    }
}