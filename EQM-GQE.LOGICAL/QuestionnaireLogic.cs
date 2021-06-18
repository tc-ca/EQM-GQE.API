using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Interfaces;

namespace EQM_GQE.LOGICAL
{
    public class QuestionnaireLogic : IQuestionnaireLogic
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;
      
        public QuestionnaireLogic(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<long> Add(Questionnaire oQuestionnaire)
        {
            Questionnaire questionnaire = new()
            {
                Template = oQuestionnaire.Template,
                DocumentTitle = oQuestionnaire.DocumentTitle,
                BusinessLineId = oQuestionnaire.BusinessLineId,
                DocumentTypeId = oQuestionnaire.DocumentTypeId,
                DocumentStatusId = oQuestionnaire.DocumentStatusId,
                SecurityClassificationId = oQuestionnaire.SecurityClassificationId,
                CreatedOn = oQuestionnaire.CreatedOn,
                ModifiedOn = oQuestionnaire.ModifiedOn,
                CreatedBy = oQuestionnaire.CreatedBy,
                ModifiedBy = oQuestionnaire.ModifiedBy,
                ActiveStatus = oQuestionnaire.ActiveStatus,
                DocumentVersion = oQuestionnaire.DocumentVersion,
                EffectiveDate = oQuestionnaire.EffectiveDate,
                ChangeSummary = oQuestionnaire.ChangeSummary,
                OrganisationAccessibility = oQuestionnaire.OrganisationAccessibility,
                ParentId = oQuestionnaire.ParentId
            };

            var id = await _questionnaireRepository.Add(questionnaire);
            return id;
        }

        public async Task<bool> Update(Questionnaire Questionnaire)
        {                 
            return await _questionnaireRepository.Update(Questionnaire);
        }
        
        public Questionnaire Get(int id)
        {
            var questionnaire = _questionnaireRepository.Get(id);
            return questionnaire;

        }
    }
}
