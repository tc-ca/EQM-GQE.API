using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Models;

namespace EQM_GQE.SHARED_RESOURCES.Interfaces
{
    public interface IDocumentTypeRepository
    {
        Task<int> Add(DocumentType documentType);

        Task<bool> Update(DocumentType documentType);

        DocumentType Get(int id);

        Task<List<DocumentType>> GetAllAsync();
    }
}