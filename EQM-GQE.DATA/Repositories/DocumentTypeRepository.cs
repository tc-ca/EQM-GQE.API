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
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IQuestionnaireContext _context;

        public DocumentTypeRepository(IQuestionnaireContext context)
        {
            _context  = context;
        }

         public async Task<int> Add(DocumentType documentType)
        {
            await _context.DocumentTypes.AddAsync(documentType, CancellationToken.None);
            await _context.SaveChangesAsync(CancellationToken.None);
            return documentType.DocumentTypeId;
        }

        public async Task<bool> Update(DocumentType documentType)
        {
            _context.DocumentTypes.Update(documentType);
            await _context.SaveChangesAsync(CancellationToken.None);
            return true;               
        }

        public DocumentType Get(int id)
        {
            var result = _context.DocumentTypes.FirstOrDefault(o => o.DocumentTypeId == id);
            return result;
        }

        public async Task<List<DocumentType>> GetAllAsync()
        {
            var result = await _context.DocumentTypes.ToListAsync();
            return result;
        }
    }
}