using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Models;

namespace EQM_GQE.SHARED_RESOURCES.Interfaces
{
    public interface IBusinessLineLogic
    {
        BusinessLine Get(int id);
        Task<List<BusinessLine>> GetAllAsync();
        Task<List<BusinessLine>> GetAllActiveAsync();
        Task<int> Add(BusinessLine businessLine);
        Task<bool> Update(BusinessLine businessLine);
    }
}