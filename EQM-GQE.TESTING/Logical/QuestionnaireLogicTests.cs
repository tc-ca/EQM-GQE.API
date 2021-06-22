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
using FluentAssertions;



namespace EQM_GQE.TESTING
{
    public class QuestionnaireLogicTests
    {

        private Mock<IQuestionnaireRepository> _questionnaireRepository;
        private IList<Questionnaire> _questionnaires; 
        private QuestionnaireLogic _questionnaireLogic;
        private int maxId;
        
        public QuestionnaireLogicTests()
        {
           maxId = 2;
           
           _questionnaires = new List<Questionnaire>()
           {
            new Questionnaire
            {
               Id = 1,
                Template = "Moq Test",
                DocumentTitle_EN = "Moq Test",
                DocumentTitle_FR = "[fr]Moq Test",
                CreatedOn = System.DateTime.Now,
                ModifiedOn = System.DateTime.Now,
                CreatedBy = "Moq Test User",
                ModifiedBy = "Moq Test User",
                ActiveStatus = true,
                DocumentVersion = 1,
                EffectiveDate = System.DateTime.Now,
                ChangeSummary_EN = "Moq Test Summary",
                ChangeSummary_FR = "[fr]Moq Test Summary",
                OrganisationAccessibility = true,
                ParentId = 0
            },
             new Questionnaire
            {
               Id = 2,
                Template = "Moq Test 2",
                DocumentTitle_EN = "Moq Test 2",
                DocumentTitle_FR = "[fr]Moq Test 2",
                CreatedOn = System.DateTime.Now,
                ModifiedOn = System.DateTime.Now,
                CreatedBy = "Moq Test User 2",
                ModifiedBy = "Moq Test User 2",
                ActiveStatus = true,
                DocumentVersion = 1,
                EffectiveDate = System.DateTime.Now,
                ChangeSummary_EN = "Moq Test Summary 2",
                ChangeSummary_FR = "[fr]Moq Test Summary 2",
                OrganisationAccessibility = false,
                ParentId = 0
            }
        };
            _questionnaireRepository = new Mock<IQuestionnaireRepository>();
            _questionnaireRepository.Setup(x => x.Update(It.IsAny<Questionnaire>())).ReturnsAsync((Questionnaire q) =>
                {
                    var toRemove = _questionnaires.FirstOrDefault(x => x.Id == q.Id);
                    _questionnaires.Remove(toRemove);
                    _questionnaires.Add(q);
                    return true;
            });
        
             _questionnaireRepository.Setup(x => x.Add(It.IsAny<Questionnaire>())).ReturnsAsync((Questionnaire q) =>
            {
                q.Id = maxId + 1;
                _questionnaires.Add(q);
                return q.Id;
            }
             );

             _questionnaireRepository.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) => 
             {                    
                    var result = _questionnaires.Where(q => q.Id == id).FirstOrDefault();
                    return result;
             });
             
            _questionnaireLogic = new QuestionnaireLogic(_questionnaireRepository.Object);
        }

        //Happy Path
        [Fact]
        public void GetQuestionnaire_ShouldGet_MoqTest2()
        {
        //Arrange
        
        
        //Act
        var result = _questionnaireLogic.Get(2);
        
        //Assert
        result.DocumentTitle_EN.Should().Be("Moq Test 2");
        }

        //Null Path
        [Fact]
        public void GetQuestionnaire_ShouldBe_NotFound()
        {
        //Arrange
        QuestionnaireLogic _questionnaireLogic = new QuestionnaireLogic(_questionnaireRepository.Object);
        
        //Act
        var result = _questionnaireLogic.Get(100);
        
        //Assert
        result.Should().Be(null);
        }

        //Happy Path
        [Fact]
        public void AddQuestionnaire_ShouldHave_NewQuestionnaire()
        {
            // Arange  
            var newid = maxId + 1;

            var q = new Questionnaire{
                Template = "Post",
                DocumentTitle_EN = "Post",
                DocumentTitle_FR = "Post",
                CreatedOn = System.DateTime.Now,
                ModifiedOn = System.DateTime.Now,
                CreatedBy = "MOULAST",
                ModifiedBy = "MOULAST",
                ActiveStatus = true,
                DocumentVersion = 1,
                EffectiveDate = System.DateTime.Now,
                ChangeSummary_EN = "Post Test",
                ChangeSummary_FR = "Post Test",
                OrganisationAccessibility = true,
                ParentId = 0
            };

            var id = Task.Run(async () => await _questionnaireLogic.Add(q)).GetAwaiter().GetResult();
           
            // Act
            var result = _questionnaireLogic.Get(newid);


            // Assert
            result.CreatedBy.Should().Be("MOULAST");
        }

        //Happy Path
        [Fact]
        public void UpdateQuestionnaire_ShouldHaveTitle_Test()
        {
            // Arange               
            var q = _questionnaireLogic.Get(1);
            // Act
            q.DocumentTitle_EN = "Test";
            var flag = Task.Run(async () => await _questionnaireLogic.Update(q)).GetAwaiter().GetResult();

            // Assert
            var result = _questionnaireLogic.Get(1);
            result.DocumentTitle_EN.Should().Be("Test");
        }
    }
}
