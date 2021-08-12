using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Models;
using EntityLibrary.Repositories.Interfaces;
using System.Data.Entity;
using EntityLibrary.EF;


namespace EntityLibrary.Repositories.Implementations
{
    public class MessageRepository : IMessageInterface
    {
        private DataManager _dataManager;
        public MessageRepository(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public void AddMessage(Message message)
        {
            
        }

        public IEnumerable<Message> GetMessagesByFromIdAndToId(int idAccount)
        {
            throw new NotImplementedException();
        }
    }
}
