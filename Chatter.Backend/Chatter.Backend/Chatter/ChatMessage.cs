using System;

namespace Chatter.Backend.Chatter
{
    public class ChatMessage
    {
        public string ClientUniqueId { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }
    }
}