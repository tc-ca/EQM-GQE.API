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
    public class DocumentStatusTests
    {
        private Mock<IDocumentStatusRepository> _documentStatusRepository;
        private IList<DocumentStatus> _documentStatus;
        private DocumentStatusLogic _documentStatusLogic;
        private int maxId;

        public DocumentStatusTests()
        {
            maxId = 2;

            _documentStatus = new List<DocumentStatus>()
           {
            new DocumentStatus
            {
               DocumentStatusId = 1,
               DocumentStatus_EN = "Published",
               DeletedOn = null
            },
             new DocumentStatus
            {
               DocumentStatusId = 2,
               DocumentStatus_EN = "Test",
               DeletedOn = DateTime.Now
            }
        };
            _documentStatusRepository = new Mock<IDocumentStatusRepository>();
            _documentStatusRepository.Setup(x => x.Update(It.IsAny<DocumentStatus>())).ReturnsAsync((DocumentStatus q) =>
            {
                var toRemove = _documentStatus.FirstOrDefault(x => x.DocumentStatusId == q.DocumentStatusId);
                _documentStatus.Remove(toRemove);
                _documentStatus.Add(q);
                return true;
            });

            _documentStatusRepository.Setup(x => x.Add(It.IsAny<DocumentStatus>())).ReturnsAsync((DocumentStatus q) =>
            {
                maxId = maxId + 1;
                q.DocumentStatusId = maxId;
                _documentStatus.Add(q);
                return q.DocumentStatusId;
            }
            );

            _documentStatusRepository.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                var result = _documentStatus.Where(q => q.DocumentStatusId == id).FirstOrDefault();
                return result;
            });

            _documentStatusRepository.Setup(x => x.GetAllAsync()).ReturnsAsync((List<DocumentStatus>)_documentStatus);

            _documentStatusLogic = new DocumentStatusLogic(_documentStatusRepository.Object);
        }

        //Happy Path
        [Fact]
        public void GetDocumentStatuse_ShouldGet_Test()
        {
            //Arrange


            //Act
            var result = _documentStatusLogic.Get(2);

            //Assert
            result.DocumentStatus_EN.Should().Be("Test");
        }

        //Null Path
        [Fact]
        public void GetDocumentStatus_ShouldBe_NotFound()
        {
            //Arrange

            //Act
            var result = _documentStatusLogic.Get(100);

            //Assert
            result.Should().Be(null);
        }

        //Happy Path
        [Fact]
        public void GetAllAsync_ShouldHave_Count2()
        {
            //Arange

            //Act
            var list = Task.Run(async () => await _documentStatusLogic.GetAllAsync()).GetAwaiter().GetResult();

            //Assert
            list.Count.Should().Be(2);
        }

        //Happy Path
        [Fact]
        public void AddDocumentStatus_ShouldHave_NewDocumentStatus()
        {
            // Arange  
            var newid = maxId + 1;

            var q = new DocumentStatus
            {
                DocumentStatus_EN = "Test2"
            };

            var id = Task.Run(async () => await _documentStatusLogic.Add(q)).GetAwaiter().GetResult();

            // Act
            var result = _documentStatusLogic.Get(newid);


            // Assert
            result.DocumentStatus_EN.Should().Be("Test2");
        }

        //Happy Path
        [Fact]
        public void UpdateDocumentStatus_ShouldHaveTitle_Test()
        {
            // Arange               
            var q = _documentStatusLogic.Get(1);
            // Act
            q.DocumentStatus_EN = "Test";
            var flag = Task.Run(async () => await _documentStatusLogic.Update(q)).GetAwaiter().GetResult();

            // Assert
            var result = _documentStatusLogic.Get(1);
            result.DocumentStatus_EN.Should().Be("Test");
        }

        //Happy Path
        [Fact]
        public void GetAllActive_ShouldHave_Count1()
        {
            //Arrange


            //Act
            var list = Task.Run(async () => await _documentStatusLogic.GetAllActiveAsync()).GetAwaiter().GetResult();

            //Assert
            list.Should().HaveCount(1);
        }
    }

}