using EQM_GQE.LOGICAL;
using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace EQM_GQE.TESTING
{
    public class DocumentTypeTests
    {
        private Mock<IDocumentTypeRepository> _documentTypeRepository;
        private IList<DocumentType> _documentType;
        private DocumentTypeLogic _documentTypeLogic;
        private int maxId;

        public DocumentTypeTests()
        {
            maxId = 2;
            _documentType = new List<DocumentType>()
           {
            new DocumentType
            {
               DocumentTypeId = 1,
               DocumentType_EN = "InspectionEn",
               DocumentType_FR = "InspectionFr",
               DeletedOn = null
            },
             new DocumentType
            {
               DocumentTypeId = 2,
               DocumentType_EN = "TestEn",
               DocumentType_FR = "TestFr",
               DeletedOn = DateTime.Now
            }
        };
            _documentTypeRepository = new Mock<IDocumentTypeRepository>();

            _documentTypeRepository.Setup(x => x.Update(It.IsAny<DocumentType>())).ReturnsAsync((DocumentType q) =>
            {
                var toRemove = _documentType.FirstOrDefault(x => x.DocumentTypeId == q.DocumentTypeId);
                _documentType.Remove(toRemove);
                _documentType.Add(q);
                return true;
            });

            _documentTypeRepository.Setup(x => x.Add(It.IsAny<DocumentType>())).ReturnsAsync((DocumentType q) =>
            {
                maxId = maxId + 1;
                q.DocumentTypeId = maxId;
                _documentType.Add(q);
                return q.DocumentTypeId;
            }
            );
            _documentTypeRepository.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                var result = _documentType.Where(q => q.DocumentTypeId == id).FirstOrDefault();
                return result;
            });
            _documentTypeRepository.Setup(x => x.GetAllAsync()).ReturnsAsync((List<DocumentType>)_documentType);
            _documentTypeLogic = new DocumentTypeLogic(_documentTypeRepository.Object);
        }

        //Happy Path
        [Fact]
        public void GetDocumentType_ShouldGet_InspectionFr()
        {
            //Arrange


            //Act
            var result = _documentTypeLogic.Get(2);

            //Assert
            result.DocumentType_FR.Should().Be("TestFr");
        }
        //Null Path
        [Fact]
        public void GetDocumentType_ShouldBe_NotFound()
        {
            //Arrange

            //Act
            var result = _documentTypeLogic.Get(100);

            //Assert
            result.Should().Be(null);
        }
        //Happy Path
        [Fact]
        public void GetAllAsync_ShouldHave_Count2()
        {
            //Arange

            //Act
            var list = Task.Run(async () => await _documentTypeLogic.GetAllAsync()).GetAwaiter().GetResult();

            //Assert
            list.Count.Should().Be(2);
        }

        //Happy Path
        [Fact]
        public void GetAllActive_ShouldHave_Count1()
        {
            //Arrange


            //Act
            var list = Task.Run(async () => await _documentTypeLogic.GetAllActiveAsync()).GetAwaiter().GetResult();

            //Assert
            list.Should().HaveCount(1);
        }
        //Happy Path
        [Fact]
        public void AddDocumentType_ShouldHave_NewDocumentType()
        {
            // Arange  
            var newid = maxId + 1;

            var q = new DocumentType
            {
                DocumentType_EN = "doc type EN"
            };

            var id = Task.Run(async () => await _documentTypeLogic.Add(q)).GetAwaiter().GetResult();

            // Act
            var result = _documentTypeLogic.Get(newid);


            // Assert
            result.DocumentType_EN.Should().Be("doc type EN");
        }

        //Happy Path
        [Fact]
        public void UpdateDocumentType_ShouldHaveTitle_Test()
        {
            // Arange               
            var q = _documentTypeLogic.Get(1);
            // Act
            q.DocumentType_EN = "Test";
            var flag = Task.Run(async () => await _documentTypeLogic.Update(q)).GetAwaiter().GetResult();

            // Assert
            var result = _documentTypeLogic.Get(1);
            result.DocumentType_EN.Should().Be("Test");
        }

    }

}