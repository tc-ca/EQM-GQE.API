using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Models;

namespace EQM_GQE.SHARED_RESOURCES.Interfaces
{
    public interface IBusinessLineAccessControlLogic
    {
        BusinessLineAccessControl Get(int id);
        Task<List<BusinessLineAccessControl>> GetAllAsync();
        Task<List<BusinessLineAccessControl>> GetAllActiveAsync();
        Task<int> Add(BusinessLineAccessControl accessControl);
        Task<bool> Update(BusinessLineAccessControl accessControl);
    }
}
