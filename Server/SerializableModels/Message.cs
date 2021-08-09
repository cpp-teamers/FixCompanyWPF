using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SerializableModels
{
    [Serializable]
    public class Message
    {
        public Message() { }
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SentDate { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
    }
}
