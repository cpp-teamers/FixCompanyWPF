using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Models;

namespace EntityLibrary.Repositories.Interfaces
{
    interface IRedynessStatusRepository
    {
        IEnumerable<ReadynessStatus> GetAllReadynessStatuses();
        ReadynessStatus GetReadynessStatusById(int statusId);
        void AddStatus(ReadynessStatus addedStatus);
        void ChangeStatus(ReadynessStatus changedStatus);
        void RemoveStatus(int deletedStatusId);
    }
}
