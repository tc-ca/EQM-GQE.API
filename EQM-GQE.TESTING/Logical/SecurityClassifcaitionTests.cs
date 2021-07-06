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
using System;

namespace EQM_GQE.TESTING
{
    public class SecurityClassificationTests
    {
        private Mock<ISecurityClassificationRepository> _securityClassificationRepository;
        private IList<SecurityClassification> _securityClassification;
        private SecurityClassificationLogic _securityClassificationLogic;
        private int maxId;

        public SecurityClassificationTests()
        {
            maxId = 2;

            _securityClassification = new List<SecurityClassification>()
           {
            new SecurityClassification
            {
               SecurityClassificationId = 1,
               SecurityClassification_EN = "testEn",
               SecurityClassification_FR = "testFr",
               DeletedOn = null
            },
             new SecurityClassification
            {
               SecurityClassificationId = 2,
               SecurityClassification_EN = "En",
               SecurityClassification_FR = "Fr",
               DeletedOn = DateTime.Now
            }
        };
            _securityClassificationRepository = new Mock<ISecurityClassificationRepository>();
            _securityClassificationRepository.Setup(x => x.Update(It.IsAny<SecurityClassification>())).ReturnsAsync((SecurityClassification q) =>
            {
                var toRemove = _securityClassification.FirstOrDefault(x => x.SecurityClassificationId == q.SecurityClassificationId);
                _securityClassification.Remove(toRemove);
                _securityClassification.Add(q);
                return true;
            });

            _securityClassificationRepository.Setup(x => x.Add(It.IsAny<SecurityClassification>())).ReturnsAsync((SecurityClassification q) =>
            {
                maxId = maxId + 1;
                q.SecurityClassificationId = maxId;
                _securityClassification.Add(q);
                return q.SecurityClassificationId;
            }
            );

            _securityClassificationRepository.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                var result = _securityClassification.Where(q => q.SecurityClassificationId == id).FirstOrDefault();
                return result;
            });

            _securityClassificationRepository.Setup(x => x.GetAllAsync()).ReturnsAsync((List<SecurityClassification>) _securityClassification);

            _securityClassificationLogic = new SecurityClassificationLogic(_securityClassificationRepository.Object);
        }

        //Happy Path
        [Fact]
        public void GetSecurityClassification_ShouldGet_En()
        {
            //Arrange


            //Act
            var result = _securityClassificationLogic.Get(2);

            //Assert
            result.SecurityClassification_EN.Should().Be("En");
        }

        //Null Path
        [Fact]
        public void GetSecurityClassification_ShouldBe_NotFound()
        {
            //Arrange

            //Act
            var result = _securityClassificationLogic.Get(100);

            //Assert
            result.Should().Be(null);
        }

        //Happy Path
        [Fact]
        public void GetAllAsync_ShouldHave_Count2()
        {
            //Arange

            //Act
            var list = Task.Run(async () => await _securityClassificationLogic.GetAllAsync()).GetAwaiter().GetResult();

            //Assert
            list.Count.Should().Be(2);
        }

        //Happy Path
        [Fact]
        public void AddSecurityClassification_ShouldHave_NewSecurityClassification()
        {
            // Arange  
            var newid = maxId + 1;

            var q = new SecurityClassification
            {
                SecurityClassification_EN = "en test"
            };

            var id = Task.Run(async () => await _securityClassificationLogic.Add(q)).GetAwaiter().GetResult();

            // Act
            var result = _securityClassificationLogic.Get(newid);


            // Assert
            result.SecurityClassification_EN.Should().Be("en test");
        }

        //Happy Path
        [Fact]
        public void UpdateSecurityClassification_ShouldHaveTitle_Test()
        {
            // Arange               
            var q = _securityClassificationLogic.Get(1);
            // Act
            q.SecurityClassification_EN = "Test";
            var flag = Task.Run(async () => await _securityClassificationLogic.Update(q)).GetAwaiter().GetResult();

            // Assert
            var result = _securityClassificationLogic.Get(1);
            result.SecurityClassification_EN.Should().Be("Test");
        }

        //Happy Path
        [Fact]
        public void GetAllActive_ShouldHave_Count1()
        {
            //Arrange


            //Act
            var list = Task.Run(async () => await _securityClassificationLogic.GetAllActiveAsync()).GetAwaiter().GetResult();

            //Assert
            list.Should().HaveCount(1);
        }
    }

}