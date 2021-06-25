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
        private readonly IBusinessLineRepository _businessLineRepository;
        public BusinessLineLogic(IBusinessLineRepository businessLineRepository)
        {
            _businessLineRepository = businessLineRepository;
        }
        public async Task<int> Add(BusinessLine businessLine)
        {
            BusinessLine businessLineToAdd = new()
            {
                BusinessLineId = businessLine.BusinessLineId,
                Abbreviation_EN = businessLine.Abbreviation_EN,
                Abbreviation_FR = businessLine.Abbreviation_FR,
                BusinessName_EN = businessLine.BusinessName_EN,
                BusinessName_FR = businessLine.BusinessName_FR,
                CreatedOn = businessLine.CreatedOn,
                DeletedOn = businessLine.DeletedOn,
                ModifiedOn = businessLine.ModifiedOn
            };

            var id = await _businessLineRepository.Add(businessLineToAdd);
            return id;
        }

        public BusinessLine Get(int id)
        {
            var businessLine = _businessLineRepository.Get(id);
            return businessLine;
        }

        public async Task<List<BusinessLine>> GetAllActiveAsync()
        {
              var businessLines = await _businessLineRepository.GetAllAsync(); 
              businessLines = businessLines.Where(q => q.DeletedOn == null).ToList();
              return businessLines;
        }

        public async Task<List<BusinessLine>> GetAllAsync()
        {
            var businessLines = await _businessLineRepository.GetAllAsync();            
            return businessLines;
        }

        public async Task<bool> Update(BusinessLine businessLine)
        {
            return await _businessLineRepository.Update(businessLine);
        }
    }
}