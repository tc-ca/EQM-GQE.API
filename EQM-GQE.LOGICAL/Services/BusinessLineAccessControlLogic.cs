using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;

namespace EQM_GQE.LOGICAL.Services
{
    public class BusinessLineAccessControlLogic : IBusinessLineAccessControlLogic
    {
        private readonly IBusinessLineAccessControlRepository _accessControlRepository;
        public BusinessLineAccessControlLogic(IBusinessLineAccessControlRepository accessControlRepository)
        {
            _accessControlRepository = accessControlRepository;
        }
        public async Task<int> Add(BusinessLineAccessControl accessControl)
        {
            BusinessLineAccessControl accessControlToAdd = new()
            {
                Id = accessControl.Id,
                BusinessLineId = accessControl.BusinessLineId,
                UserId = accessControl.UserId,
                Active = accessControl.Active,
                CreatedOn = accessControl.CreatedOn,
                DeletedOn = accessControl.DeletedOn,
                ModifiedOn = accessControl.ModifiedOn
            };

            var id = await _accessControlRepository.Add(accessControlToAdd);
            return id;
        }

        public BusinessLineAccessControl Get(int id)
        {
            var accessControl = _accessControlRepository.Get(id);
            return accessControl;
        }

        public async Task<List<BusinessLineAccessControl>> GetAllActiveAsync()
        {
            var accessControl = await _accessControlRepository.GetAllAsync();
            accessControl = accessControl.Where(q => q.DeletedOn == null).ToList();
            return accessControl;
        }

        public async Task<List<BusinessLineAccessControl>> GetAllAsync()
        {
            var accessControl = await _accessControlRepository.GetAllAsync();
            return accessControl;
        }

        public async Task<bool> Update(BusinessLineAccessControl accessControl)
        {
            return await _accessControlRepository.Update(accessControl);
        }
    }
}
