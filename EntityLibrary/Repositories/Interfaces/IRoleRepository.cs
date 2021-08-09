using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Models;

namespace EntityLibrary.Repositories.Interfaces
{
    interface IRoleRepository
    {
        IEnumerable<Role> GetAllRoles();
        Role GetRoleById(int roleId);
        void AddRole(Role addedRole);
        void ChangeRole(Role changedRole);
        void RemoveRole(int deleteRoleId);
    }
}
