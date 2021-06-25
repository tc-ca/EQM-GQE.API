using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Interfaces;

namespace EQM_GQE.LOGICAL
{
    public class BusinessLineLogic : IBusinessLineLogic
    {
        public Task<int> Add(BusinessLine businessLine)
        {
            throw new NotImplementedException();
        }

        public BusinessLine Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BusinessLine>> GetAllActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<BusinessLine>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(BusinessLine businessLine)
        {
            throw new NotImplementedException();
        }
    }
}