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
using EQM_GQE.LOGICAL.Services;

namespace EQM_GQE.TESTING.Logical
{
    public class BusinessLineAccessControlTests
    {
        private Mock<IBusinessLineAccessControlRepository> _accessControlRepository;
        private IList<BusinessLineAccessControl> _accessControl;
        private BusinessLineAccessControlLogic _accessControlLogic;
        private int maxId;

        public BusinessLineAccessControlTests()
        {
            maxId = 2;

            _accessControl = new List<BusinessLineAccessControl>()
           {
            new BusinessLineAccessControl
            {
               Id = 1,
               BusinessLineId = new BusinessLine 
               { 
                   BusinessLineId = 1
               },
               UserId = "user1",              
               DeletedOn = null
            },
             new BusinessLineAccessControl
            {
              Id = 2,
               BusinessLineId = new BusinessLine
               {
                   BusinessLineId = 2
               },
               UserId = "user2",
               DeletedOn = DateTime.Now
            }
        };
            _accessControlRepository = new Mock<IBusinessLineAccessControlRepository>();
            _accessControlRepository.Setup(x => x.Update(It.IsAny<BusinessLineAccessControl>())).ReturnsAsync((BusinessLineAccessControl q) =>
            {
                var toRemove = _accessControl.FirstOrDefault(x => x.Id == q.Id);
                _accessControl.Remove(toRemove);
                _accessControl.Add(q);
                return true;
            });

            _accessControlRepository.Setup(x => x.Add(It.IsAny<BusinessLineAccessControl>())).ReturnsAsync((BusinessLineAccessControl q) =>
            {
                maxId = maxId + 1;
                q.Id = maxId;
                _accessControl.Add(q);
                return q.Id;
            }
            );

            _accessControlRepository.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                var result = _accessControl.Where(q => q.Id == id).FirstOrDefault();
                return result;
            });

            _accessControlRepository.Setup(x => x.GetAllAsync()).ReturnsAsync((List<BusinessLineAccessControl>)_accessControl);

            _accessControlLogic = new BusinessLineAccessControlLogic(_accessControlRepository.Object);
        }

        //Happy Path
        [Fact]
        public void GetBusinessLineAccessControl_ShouldGet_User2()
        {
            //Arrange


            //Act
            var result = _accessControlLogic.Get(2);

            //Assert
            result.UserId.Should().Be("user2");
        }

        //Null Path
        [Fact]
        public void GetBusinessLineAccessControl_ShouldBe_NotFound()
        {
            //Arrange

            //Act
            var result = _accessControlLogic.Get(100);

            //Assert
            result.Should().Be(null);
        }

        //Happy Path
        [Fact]
        public void GetAllAsync_ShouldHave_Count2()
        {
            //Arange

            //Act
            var list = Task.Run(async () => await _accessControlLogic.GetAllAsync()).GetAwaiter().GetResult();

            //Assert
            list.Count.Should().Be(2);
        }

        //Happy Path
        [Fact]
        public void AddBusinessLineAccessControl_ShouldHave_NewAccessControl()
        {
            // Arange  
            var newid = maxId + 1;

            var q = new BusinessLineAccessControl
            {
                UserId = "newUser"
            };

            var id = Task.Run(async () => await _accessControlLogic.Add(q)).GetAwaiter().GetResult();

            // Act
            var result = _accessControlLogic.Get(newid);


            // Assert
            result.UserId.Should().Be("newUser");
        }

        //Happy Path
        [Fact]
        public void UpdateBusinessLineAccessControl_ShouldHaveUser_Test()
        {
            // Arange               
            var q = _accessControlLogic.Get(1);
            // Act
            q.UserId = "newUser";
            var flag = Task.Run(async () => await _accessControlLogic.Update(q)).GetAwaiter().GetResult();

            // Assert
            var result = _accessControlLogic.Get(1);
            result.UserId.Should().Be("newUser");
        }

        //Happy Path
        [Fact]
        public void GetAllActive_ShouldHave_Count1()
        {
            //Arrange


            //Act
            var list = Task.Run(async () => await _accessControlLogic.GetAllActiveAsync()).GetAwaiter().GetResult();

            //Assert
            list.Should().HaveCount(1);
        }
    }
}
