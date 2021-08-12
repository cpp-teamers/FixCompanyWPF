using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Models;

namespace EntityLibrary.Repositories.Interfaces
{
    interface IMessageInterface
    {
        void AddMessage(Message addesMessage);
        IEnumerable<Message> GetMessagesByFromIdAndToId(int idAccount);
    }
}
