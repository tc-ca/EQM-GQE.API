using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EQM_GQE.DATA.Repositories
{
    public class BusinessLineAccessControlRepository : IBusinessLineAccessControlRepository
    {
        private readonly IQuestionnaireContext _context;

        public BusinessLineAccessControlRepository(IQuestionnaireContext context)
        {
            _context = context;
        }

        public async Task<int> Add(BusinessLineAccessControl accessControl)
        {
            await _context.BusinessLineAccessControl.AddAsync(accessControl, CancellationToken.None);
            await _context.SaveChangesAsync(CancellationToken.None);
            return accessControl.Id;
        }

        public async Task<bool> Update(BusinessLineAccessControl accessControl)
        {
            _context.BusinessLineAccessControl.Update(accessControl);
            await _context.SaveChangesAsync(CancellationToken.None);
            return true;
        }

        public BusinessLineAccessControl Get(int id)
        {
            var result = _context.BusinessLineAccessControl.FirstOrDefault(o => o.Id == id);
            return result;
        }

        public async Task<List<BusinessLineAccessControl>> GetAllAsync()
        {
            var result = await _context.BusinessLineAccessControl.ToListAsync();
            return result;
        }
    }
}
