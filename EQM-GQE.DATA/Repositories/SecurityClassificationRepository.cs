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
    public class SecurityClassificationRepository : ISecurityClassificationRepository
    {
        private readonly IQuestionnaireContext _context;

        public SecurityClassificationRepository(IQuestionnaireContext context)
        {
            _context  = context;
        }

         public async Task<int> Add(SecurityClassification securityClassification)
        {
            await _context.SecurityClassifications.AddAsync(securityClassification, CancellationToken.None);
            await _context.SaveChangesAsync(CancellationToken.None);
            return securityClassification.SecurityClassificationId;
        }

        public async Task<bool> Update(SecurityClassification securityClassification)
        {
            _context.SecurityClassifications.Update(securityClassification);
            await _context.SaveChangesAsync(CancellationToken.None);
            return true;               
        }

        public SecurityClassification Get(int id)
        {
            var result = _context.SecurityClassifications.FirstOrDefault(o => o.SecurityClassificationId == id);
            return result;
        }

        public async Task<List<SecurityClassification>> GetAllAsync()
        {
            var result = await _context.SecurityClassifications.ToListAsync();
            return result;
        }
    }
}