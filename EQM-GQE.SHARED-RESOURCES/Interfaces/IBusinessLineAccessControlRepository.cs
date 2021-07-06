using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQM_GQE.SHARED_RESOURCES.Interfaces
{
    public interface IBusinessLineAccessControlRepository
    {
        Task<int> Add(BusinessLineAccessControl accessControl);

        Task<bool> Update(BusinessLineAccessControl accessControl);

        BusinessLineAccessControl Get(int id);

        Task<List<BusinessLineAccessControl>> GetAllAsync();
    }
}
