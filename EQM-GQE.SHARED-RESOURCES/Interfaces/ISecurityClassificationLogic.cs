using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Models;

namespace EQM_GQE.SHARED_RESOURCES.Interfaces
{
    public interface ISecurityClassificationLogic
    {
        SecurityClassification Get(int id);
        Task<List<SecurityClassification>> GetAllAsync();
        Task<List<SecurityClassification>> GetAllActiveAsync();
        Task<int> Add(SecurityClassification securityClassification);
        Task<bool> Update(SecurityClassification securityClassification);
    }
}