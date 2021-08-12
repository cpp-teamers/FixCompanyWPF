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
        public void AddMessage(Message addedMessage)
        {
            _dataManager.Messages.Add(addedMessage);
            _dataManager.SaveChanges();
        }

        public IEnumerable<Message> GetMessagesByFromIdAndToId(int idAccount)
        {
            IQueryable<Message> messages = _dataManager.Messages;
            return messages.Where(m => m.FromAccountId == idAccount || m.ToAccountId == idAccount).OrderBy(m => m.TimeStamp);
        }
    }
}
