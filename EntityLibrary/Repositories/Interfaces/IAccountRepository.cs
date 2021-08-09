using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Models;

namespace EntityLibrary.Repositories.Interfaces
{
    interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts();
        IEnumerable<Account> GetAccountsByRoleId(int roleId);
        Account GetAccountById(int accountId);
        void AddAccount(Account addedAccount);
        void ChangeAccount(Account changedAccount);
        void RemoveAccount(int deletedAccountId);
    }
}
