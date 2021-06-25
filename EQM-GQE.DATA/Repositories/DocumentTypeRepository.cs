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
    }
}