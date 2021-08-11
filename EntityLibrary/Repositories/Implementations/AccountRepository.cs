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
    class AccountRepository : IAccountRepository
    {
        private DataManager _dataManager = new DataManager();
        public void AddAccount(Account addedAccount)
        {
            _dataManager.Accounts.Add(addedAccount);
            _dataManager.SaveChanges();
        }

        public void ChangeAccount(Account changedAccount)
        {
            _dataManager.Accounts.Attach(changedAccount);
            _dataManager.Entry(changedAccount).State = EntityState.Modified;
            _dataManager.SaveChanges();
        }

        public Account GetAccountById(int accountId)
        {
            return _dataManager.Accounts.Find(accountId);
        }

        public Account GetAccountByLogin(string login)
        {
            IQueryable<Account> accounts = _dataManager.Accounts;
            return accounts.FirstOrDefault(account => account.Login == login);
        }

        public IEnumerable<Account> GetAccountsByRoleId(int roleId)
        {
            return _dataManager.Roles.Find(roleId).Accounts;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _dataManager.Accounts.ToList();
        }

        public void RemoveAccount(int deletedAccountId)
        {
            var foundedAccount = _dataManager.Accounts.Find(deletedAccountId);
            _dataManager.Accounts.Remove(foundedAccount);

            _dataManager.SaveChanges();
        }
    }
}
