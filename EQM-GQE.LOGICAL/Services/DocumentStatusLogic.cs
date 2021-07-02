using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Interfaces;

namespace EQM_GQE.LOGICAL
{
    public class DocumentStatusLogic : IDocumentStatusLogic
    {
        private readonly IDocumentStatusRepository _documentStatusRepository;
        public DocumentStatusLogic(IDocumentStatusRepository documentStatusRepository)
        {
            _documentStatusRepository = documentStatusRepository;
        }
        public async Task<int> Add(DocumentStatus documentStatus)
        {
            DocumentStatus documentStatusToAdd = new()
            {
                DocumentStatusId = documentStatus.DocumentStatusId,
                DocumentStatus_EN = documentStatus.DocumentStatus_EN,
                DocumentStatus_FR = documentStatus.DocumentStatus_FR,
                CreatedOn = documentStatus.CreatedOn,
                DeletedOn = documentStatus.DeletedOn,
                ModifiedOn = documentStatus.ModifiedOn
            };

            var id = await _documentStatusRepository.Add(documentStatusToAdd);
            return id;
        }

        public DocumentStatus Get(int id)
        {
            var documentStatus = _documentStatusRepository.Get(id);
            return documentStatus;
        }

        public async Task<List<DocumentStatus>> GetAllActiveAsync()
        {
            var documentStatus = await _documentStatusRepository.GetAllAsync();
            documentStatus = documentStatus.Where(q => q.DeletedOn == null).ToList();
            return documentStatus;
        }

        public async Task<List<DocumentStatus>> GetAllAsync()
        {
            var documentStatus = await _documentStatusRepository.GetAllAsync();
            return documentStatus;
        }

        public async Task<bool> Update(DocumentStatus documentStatus)
        {
            return await _documentStatusRepository.Update(documentStatus);
        }
    }
}