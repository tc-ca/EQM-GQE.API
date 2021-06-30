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
    public class DocumentStatusRepository : IDocumentStatusRepository
    {
        private readonly IQuestionnaireContext _context;

        public DocumentStatusRepository(IQuestionnaireContext context)
        {
            _context  = context;
        }

          public async Task<int> Add(DocumentStatus documentStatus)
        {
            await _context.DocumentStatus.AddAsync(documentStatus, CancellationToken.None);
            await _context.SaveChangesAsync(CancellationToken.None);
            return documentStatus.DocumentStatusId;
        }

        public async Task<bool> Update(DocumentStatus documentStatus)
        {
            _context.DocumentStatus.Update(documentStatus);
            await _context.SaveChangesAsync(CancellationToken.None);
            return true;               
        }

        public DocumentStatus Get(int id)
        {
            var result = _context.DocumentStatus.FirstOrDefault(o => o.DocumentStatusId == id);
            return result;
        }

        public async Task<List<DocumentStatus>> GetAllAsync()
        {
            var result = await _context.DocumentStatus.ToListAsync();
            return result;
        }
    }
}