using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Interfaces;

namespace EQM_GQE.LOGICAL
{
    public class DocumentTypeLogic : IDocumentTypeLogic
    {
        private readonly IDocumentTypeRepository _documentTypeRepository;
        public DocumentTypeLogic(IDocumentTypeRepository documentTypeRepository)
        {
            _documentTypeRepository = documentTypeRepository;
        }
        public DocumentType Get(int id)
        {
            var documentType = _documentTypeRepository.Get(id);
            return documentType;
        }
        public async Task<List<DocumentType>> GetAllAsync()
        {
            var documentType = await _documentTypeRepository.GetAllAsync();
            return documentType;
        }

    }
}