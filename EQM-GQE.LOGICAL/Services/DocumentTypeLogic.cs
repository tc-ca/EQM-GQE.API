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
        public async Task<List<DocumentType>> GetAllActiveAsync()
        {
            var businessLines = await _documentTypeRepository.GetAllAsync();
            businessLines = businessLines.Where(q => q.DeletedOn == null).ToList();
            return businessLines;
        }
        public async Task<int> Add(DocumentType documentType)
        {
            DocumentType documentTypeToAdd = new()
            {
                DocumentTypeId = documentType.DocumentTypeId,
                DocumentType_EN = documentType.DocumentType_EN,
                DocumentType_FR = documentType.DocumentType_FR,                
                CreatedOn = documentType.CreatedOn,
                DeletedOn = documentType.DeletedOn,
                ModifiedOn = documentType.ModifiedOn
            };

            var id = await _documentTypeRepository.Add(documentTypeToAdd);
            return id;
        }
        public async Task<bool> Update(DocumentType documentType)
        {
            return await _documentTypeRepository.Update(documentType);
        }
    }
}