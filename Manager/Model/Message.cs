using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model
{
    public class ConversationMessage
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string MessageStatus { get; set; }
        public string TimeStamp { get; set; }
    }
}
