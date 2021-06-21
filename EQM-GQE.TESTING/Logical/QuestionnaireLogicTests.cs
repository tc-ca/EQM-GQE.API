using EQM_GQE.API.Controllers;
using EQM_GQE.LOGICAL;
using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;
using System.Linq;
using System.Collections.Generic;



namespace EQM_GQE.TESTING
{
    public class QuestionnaireLogicTests
    {
        
        private Questionnaire _questionnaire;
        Mock<IQuestionnaireRepository> _questionnaireRepository;

        private IList<Questionnaire> _questionnaires; 

        public QuestionnaireLogicTests()
        {
           long id = 1;
           _questionnaires = new List<Questionnaire>()
           {
            new Questionnaire
            {
               Id = 1,
                Template = "Moq Test",
                DocumentTitle = "Moq Test",
                BusinessLineId = 1,
                DocumentTypeId = 1,
                DocumentStatusId = 1,
                SecurityClassificationId = 1,
                CreatedOn = System.DateTime.Now,
                ModifiedOn = System.DateTime.Now,
                CreatedBy = "Moq Test User",
                ModifiedBy = "Moq Test User",
                ActiveStatus = true,
                DocumentVersion = 1,
                EffectiveDate = System.DateTime.Now,
                ChangeSummary = "Moq Test Summary",
                OrganisationAccessibility = true,
                ParentId = 0
            },
             new Questionnaire
            {
               Id = 2,
                Template = "Moq Test 2",
                DocumentTitle = "Moq Test 2",
                BusinessLineId = 1,
                DocumentTypeId = 1,
                DocumentStatusId = 1,
                SecurityClassificationId = 1,
                CreatedOn = System.DateTime.Now,
                ModifiedOn = System.DateTime.Now,
                CreatedBy = "Moq Test User 2",
                ModifiedBy = "Moq Test User 2",
                ActiveStatus = true,
                DocumentVersion = 1,
                EffectiveDate = System.DateTime.Now,
                ChangeSummary = "Moq Test Summary 2",
                OrganisationAccessibility = false,
                ParentId = 0
            }
        };
            _questionnaireRepository = new Mock<IQuestionnaireRepository>();
            _questionnaire = _questionnaires.Where(q => q.Id == id).FirstOrDefault();
            _questionnaireRepository.Setup(x => x.Update(_questionnaire)).ReturnsAsync((true));
        
             _questionnaireRepository.Setup(x => x.Add(It.IsAny<Questionnaire>())).ReturnsAsync((Questionnaire q) =>
            {
                _questionnaires.Add(q);
                q.Id = 1;
                return q.Id;
            }
             );

        }

        [Fact]
        public void AddQuestionnaire_ShouldHaveId_Equal1()
        {
            // Arange           
            QuestionnaireLogic questionnaireLogic = new QuestionnaireLogic(_questionnaireRepository.Object);
           
            // Act
            var result = Task.Run(async () => await questionnaireLogic.Add(_questionnaire)).GetAwaiter().GetResult();


            // Assert
            long createdQuestionnaireId = result;
            Assert.Equal(1, createdQuestionnaireId);
        }

         [Fact]
        public void UpdateQuestionnaire_ShouldExist()
        {
            // Arange               
            QuestionnaireLogic questionnaireLogic = new QuestionnaireLogic(_questionnaireRepository.Object);

            // Act
            _questionnaire.DocumentTitle = "test";
            var result = Task.Run(async () => await questionnaireLogic.Update(_questionnaire)).GetAwaiter().GetResult();

            // Assert
            bool updatedQuestionnaire = result;
            Assert.True(updatedQuestionnaire);
        }
    }
}
