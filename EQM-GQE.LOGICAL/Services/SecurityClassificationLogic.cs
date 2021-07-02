using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Interfaces;

namespace EQM_GQE.LOGICAL
{
    public class SecurityClassificationLogic : ISecurityClassificationLogic
    {
        private readonly ISecurityClassificationRepository _securityClassificationRepository;
        public SecurityClassificationLogic(ISecurityClassificationRepository securityClassificationRepository)
        {
            _securityClassificationRepository = securityClassificationRepository;
        }
        public async Task<int> Add(SecurityClassification securityClassification)
        {
            SecurityClassification securityClassificationToAdd = new()
            {
                SecurityClassificationId = securityClassification.SecurityClassificationId,
                SecurityClassification_EN = securityClassification.SecurityClassification_EN,
                SecurityClassification_FR = securityClassification.SecurityClassification_FR,                
                CreatedOn = securityClassification.CreatedOn,
                DeletedOn = securityClassification.DeletedOn,
                ModifiedOn = securityClassification.ModifiedOn
            };

            var id = await _securityClassificationRepository.Add(securityClassificationToAdd);
            return id;
        }

        public SecurityClassification Get(int id)
        {
            var securityClassification = _securityClassificationRepository.Get(id);
            return securityClassification;
        }

        public async Task<List<SecurityClassification>> GetAllActiveAsync()
        {
            var securityClassification = await _securityClassificationRepository.GetAllAsync();
            securityClassification = securityClassification.Where(q => q.DeletedOn == null).ToList();
            return securityClassification;
        }

        public async Task<List<SecurityClassification>> GetAllAsync()
        {
            var securityClassification = await _securityClassificationRepository.GetAllAsync();
            return securityClassification;
        }

        public async Task<bool> Update(SecurityClassification securityClassification)
        {
            return await _securityClassificationRepository.Update(securityClassification);
        }
    }
}