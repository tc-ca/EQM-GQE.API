using EQM_GQE.LOGICAL;
using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EQM_GQE.TESTING
{
    public class DocumentTypeTests
    {
        private Mock<IDocumentTypeRepository> _documentTypeRepository;
        private IList<DocumentType> _documentType;
        private DocumentTypeLogic _documentTypeLogic;

        public DocumentTypeTests()
        {
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
            _documentTypeRepository.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                var result = _documentType.Where(q => q.DocumentTypeId == id).FirstOrDefault();
                return result;
            });
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
    }

}