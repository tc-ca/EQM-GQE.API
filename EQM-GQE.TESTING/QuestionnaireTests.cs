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
    public class QuestionnaireTests
    {
        
        private Questionnaire _questionnaire;
        Mock<IQuestionnaireRepository> _questionnaireRepository = new Mock<IQuestionnaireRepository>();

        public QuestionnaireTests()
        {
            _questionnaire = new Questionnaire()
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
            };

            IList<Questionnaire> questionnaires = new List<Questionnaire>();

             _questionnaireRepository.Setup(x => x.Add(It.IsAny<Questionnaire>())).ReturnsAsync((Questionnaire q) =>
            {
                questionnaires.Add(q);
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
    }
}
