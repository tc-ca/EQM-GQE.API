using EQM_GQE.API.Controllers;
using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;


namespace EQM_GQE.TESTING
{
    
    public class QuestionnaireTests
    {
        [Fact]
        public async Task QuestionnaireLogicValidator()
        {
            // Arange
            Questionnaire questionnaire = new()
            {
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

            //Mock<IQuestionnaireRepository> postQuestionnaireRepositoryValidatior = new Mock<IQuestionnaireRepository>();
            Mock<IQuestionnaireLogic> postQuestionnaireLogicValidatior = new Mock<IQuestionnaireLogic>();

            
            //postQuestionnaireLogicValidatior.re
            var questionnaireController = new QuestionnaireController(postQuestionnaireLogicValidatior.Object);

            // Act
            ActionResult<long> result = await questionnaireController.CreateQuestionnaire(questionnaire);


            // Assert
            long createdQuestionnaireId = result.Value;
            Assert.NotEqual(0, createdQuestionnaireId);
        }
    }
}
