using System;
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
    public class BusinessLineTests
    {
        private Mock<IBusinessLineRepository> _businessLineRepository;
        private IList<BusinessLine> _businessLines; 
        private BusinessLineLogic _businessLogic;
        private int maxId;
        
        public BusinessLineTests()
        {
           maxId = 2;
           
           _businessLines = new List<BusinessLine>()
           {
            new BusinessLine
            {
               BusinessLineId = 1,
               BusinessName_EN = "ISSO",
               DeletedOn = null
            },
             new BusinessLine
            {
               BusinessLineId = 2,
               BusinessName_EN = "AvSec",
               DeletedOn = DateTime.Now
            }
        };
            _businessLineRepository = new Mock<IBusinessLineRepository>();
            _businessLineRepository.Setup(x => x.Update(It.IsAny<BusinessLine>())).ReturnsAsync((BusinessLine q) =>
                {
                    var toRemove = _businessLines.FirstOrDefault(x => x.BusinessLineId == q.BusinessLineId);
                    _businessLines.Remove(toRemove);
                    _businessLines.Add(q);
                    return true;
            });
        
             _businessLineRepository.Setup(x => x.Add(It.IsAny<BusinessLine>())).ReturnsAsync((BusinessLine q) =>
            {
                maxId = maxId + 1;
                q.BusinessLineId = maxId;
                _businessLines.Add(q);
                return q.BusinessLineId;
            }
             );

             _businessLineRepository.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) => 
             {                    
                    var result = _businessLines.Where(q => q.BusinessLineId == id).FirstOrDefault();
                    return result;
             });

            _businessLineRepository.Setup(x => x.GetAllAsync()).ReturnsAsync((List<BusinessLine>)_businessLines);
            
            _businessLogic = new BusinessLineLogic(_businessLineRepository.Object);
        }

        //Happy Path
        [Fact]
        public void GetBusinessLine_ShouldGet_AvSec()
        {
        //Arrange
        
        
        //Act
        var result = _businessLogic.Get(2);
        
        //Assert
        result.BusinessName_EN.Should().Be("AvSec");
        }

        //Null Path
        [Fact]
        public void GetBusinessLine_ShouldBe_NotFound()
        {
        //Arrange
        
        //Act
        var result = _businessLogic.Get(100);
        
        //Assert
        result.Should().Be(null);
        }

        //Happy Path
        [Fact]
        public void GetAllAsync_ShouldHave_Count2()
        {
            //Arange
            
            //Act
            var list = Task.Run(async () => await _businessLogic.GetAllAsync()).GetAwaiter().GetResult();

            //Assert
            list.Count.Should().Be(2);
        }

        //Happy Path
        [Fact]
        public void AddBusinessLine_ShouldHave_NewQuestionnaire()
        {
            // Arange  
            var newid = maxId + 1;

            var q = new BusinessLine{
                Abbreviation_EN = "TC"
            };

            var id = Task.Run(async () => await _businessLogic.Add(q)).GetAwaiter().GetResult();
           
            // Act
            var result = _businessLogic.Get(newid);


            // Assert
            result.Abbreviation_EN.Should().Be("TC");
        }

        //Happy Path
        [Fact]
        public void UpdateBusinessLine_ShouldHaveTitle_Test()
        {
            // Arange               
            var q = _businessLogic.Get(1);
            // Act
            q.Abbreviation_EN = "Test";
            var flag = Task.Run(async () => await _businessLogic.Update(q)).GetAwaiter().GetResult();

            // Assert
            var result = _businessLogic.Get(1);
            result.Abbreviation_EN.Should().Be("Test");
        }

         //Happy Path
        [Fact]
        public void GetAllActive_ShouldHave_Count1()
        {
            //Arrange
           

           //Act
            var list = Task.Run(async () => await _businessLogic.GetAllActiveAsync()).GetAwaiter().GetResult();

            //Assert
            list.Should().HaveCount(1);
        }
    }

}