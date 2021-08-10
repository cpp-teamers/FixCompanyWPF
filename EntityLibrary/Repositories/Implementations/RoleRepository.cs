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
    class RoleRepository : IRoleRepository
    {
        private DataManager _dataManager = new DataManager();
        public void AddRole(Role addedRole)
        {
            _dataManager.Roles.Add(addedRole);
            _dataManager.SaveChanges();
        }

        public void ChangeRole(Role changedRole)
        {
            _dataManager.Roles.Attach(changedRole);
            _dataManager.Entry(changedRole).State = EntityState.Modified;
            _dataManager.SaveChanges();
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _dataManager.Roles.ToList();
        }

        public Role GetRoleById(int roleId)
        {
            return _dataManager.Roles.Find(roleId);
        }

        public void RemoveRole(int deleteRoleId)
        {
            var foundedRole = _dataManager.Roles.Find(deleteRoleId);
            _dataManager.Roles.Remove(foundedRole);
            _dataManager.SaveChanges();
        }
    }
}
