using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Models;

namespace EQM_GQE.SHARED_RESOURCES.Interfaces
{
    public interface IDocumentStatusLogic
    {
        DocumentStatus Get(int id);
        Task<List<DocumentStatus>> GetAllAsync();
        Task<List<DocumentStatus>> GetAllActiveAsync();
        Task<int> Add(DocumentStatus documentStatus);
        Task<bool> Update(DocumentStatus documentStatus);
    }
}