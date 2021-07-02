using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Models;

namespace EQM_GQE.SHARED_RESOURCES.Interfaces
{
    public interface IDocumentTypeLogic
    {
        DocumentType Get(int id);
        Task<List<DocumentType>> GetAllAsync();
        Task<List<DocumentType>> GetAllActiveAsync();
    }
}