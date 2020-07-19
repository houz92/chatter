using System;

namespace Chatter.Backend.Chatter
{
    public static class ChatterExtensions
    {
        public static ChatMessage CreateMessage(this string message)
        {
            return new ChatMessage
            {
                Date = DateTime.UtcNow.ToString("o"),
                Message = message ?? "empty",
                Type = typeof(ChatMessage).ToString(),
                ClientUniqueId = 1.ToString()
            };
        }
    }
}