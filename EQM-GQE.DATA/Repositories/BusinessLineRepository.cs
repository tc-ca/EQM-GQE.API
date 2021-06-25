using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace EQM_GQE.DATA.Repositories
{
    public class BusinessLineRepository : IBusinessLineRepository
    {
        private readonly IQuestionnaireContext _context;

        public BusinessLineRepository(IQuestionnaireContext context)
        {
            _context  = context;
        }

        public async Task<int> Add(BusinessLine businessLine)
        {
            await _context.BusinessLines.AddAsync(businessLine, CancellationToken.None);
            await _context.SaveChangesAsync(CancellationToken.None);
            return businessLine.BusinessLineId;
        }

        public async Task<bool> Update(BusinessLine businessLine)
        {
            _context.BusinessLines.Update(businessLine);
            await _context.SaveChangesAsync(CancellationToken.None);
            return true;               
        }

        public BusinessLine Get(int id)
        {
            var result = _context.BusinessLines.FirstOrDefault(o => o.BusinessLineId == id);
            return result;
        }

        public async Task<List<BusinessLine>> GetAllAsync()
        {
            var result = await _context.BusinessLines.ToListAsync();
            return result;
        }
    }
}