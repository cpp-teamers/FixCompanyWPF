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
    class RedynessStatusRepository : IRedynessStatusRepository
    {
        private DataManager _dataManager = new DataManager();
        public void AddStatus(ReadynessStatus addedStatus)
        {
            _dataManager.ReadynessStatuses.Add(addedStatus);
            _dataManager.SaveChanges();
        }

        public void ChangeStatus(ReadynessStatus changedStatus)
        {
            _dataManager.ReadynessStatuses.Attach(changedStatus);
            _dataManager.Entry(changedStatus).State = EntityState.Modified;

            _dataManager.SaveChanges();
        }

        public IEnumerable<ReadynessStatus> GetAllReadynessStatuses()
        {
            return _dataManager.ReadynessStatuses.ToList();
        }

        public ReadynessStatus GetReadynessStatusById(int statusId)
        {
            return _dataManager.ReadynessStatuses.Find(statusId);
        }

        public void RemoveStatus(int deletedStatusId)
        {
            var foundedStatus = _dataManager.ReadynessStatuses.Find(deletedStatusId);
            _dataManager.ReadynessStatuses.Remove(foundedStatus);
            _dataManager.SaveChanges();
        }
    }
}
