using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Models;

namespace EntityLibrary.Repositories.Interfaces
{
    interface ISolvedProblemTypeRepository
    {
        IEnumerable<SolvedProblemType> GetAllSolverProblemTypes();
        SolvedProblemType GetSolvedProblemTypeById(int solvedProblemtypeId);
        void AddSolvedProblemTypeId(SolvedProblemType addedSolvedProblemType);
        void ChangeSolvedProblemType(SolvedProblemType changedSolvedProblemType);
        void RemoveSolvedProblemType(int deletedSolvedProblemTypeId);
    }
}
