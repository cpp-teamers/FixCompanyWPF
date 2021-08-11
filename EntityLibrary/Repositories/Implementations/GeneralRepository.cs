using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.EF;

namespace EntityLibrary.Repositories.Implementations
{
    public class GeneralRepository
    {
        private DataManager _dataManager = new DataManager();
        public AccountRepository AccRepo { get; set; }
        public GeneralRepository()
        {
            AccRepo = new AccountRepository(_dataManager);
        }
    }
}
