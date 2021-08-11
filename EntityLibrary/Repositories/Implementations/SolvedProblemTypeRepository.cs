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
    public class SolvedProblemTypeRepository : ISolvedProblemTypeRepository
    {

        private DataManager _dataManager = new DataManager();
        public void AddSolvedProblemTypeId(SolvedProblemType addedSolvedProblemType)
        {
            _dataManager.SolvedProblemTypes.Add(addedSolvedProblemType);
            _dataManager.SaveChanges();
        }

        public void ChangeSolvedProblemType(SolvedProblemType changedSolvedProblemType)
        {
            _dataManager.SolvedProblemTypes.Attach(changedSolvedProblemType);
            _dataManager.Entry(changedSolvedProblemType).State = EntityState.Modified;
            _dataManager.SaveChanges();
        }

        public IEnumerable<SolvedProblemType> GetAllSolverProblemTypes()
        {
            return _dataManager.SolvedProblemTypes.ToList();
        }

        public SolvedProblemType GetSolvedProblemTypeById(int solvedProblemtypeId)
        {
            return _dataManager.SolvedProblemTypes.Find(solvedProblemtypeId);
        }

        public void RemoveSolvedProblemType(int deletedSolvedProblemTypeId)
        {
            var foundedSolvedProblemType = _dataManager.SolvedProblemTypes.Find(deletedSolvedProblemTypeId);
            _dataManager.SolvedProblemTypes.Remove(foundedSolvedProblemType);
            _dataManager.SaveChanges();
        }
    }
}
