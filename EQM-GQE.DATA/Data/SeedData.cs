using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Linq;

namespace EQM_GQE.DATA
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QuestionnaireContext(
                serviceProvider.GetRequiredService<DbContextOptions<QuestionnaireContext>>()))
            {
                // Look for any movies.
                if (context.Questionnaires.Any())
                {
                    return;   // DB has been seeded
                }


                //Seed Business Line Data
                context.BusinessLines.AddRange(
                     new BusinessLine
                     {
                         BusinessName_EN = "BusinessLine1 English",
                         BusinessName_FR = "BusinessLine1 French",
                         Abbreviation_EN = "BL1_En",
                         Abbreviation_FR = "BL1_Fr"
                     },

                     new BusinessLine
                     {
                         BusinessName_EN = "BusinessLine2 English",
                         BusinessName_FR = "BusinessLine2 French",
                         Abbreviation_EN = "BL2_En",
                         Abbreviation_FR = "BL2_Fr"
                     }
                );
                context.SaveChanges();

                //Seed Document Types Data
                context.DocumentTypes.AddRange(
                     new DocumentType
                     {
                         DocumentType_EN = "DocumentType1 English",
                         DocumentType_FR = "DocumentType1 French"
                     },

                     new DocumentType
                     {
                         DocumentType_EN = "DocumentType2 English",
                         DocumentType_FR = "DocumentType2 French"
                     }
                );
                context.SaveChanges();

                //Seed Document Status Data
                context.DocumentStatus.AddRange(
                     new DocumentStatus
                     {
                         DocumentStatus_EN = "DocumentStatus1 English",
                         DocumentStatus_FR = "DocumentStatus1 French"
                     },

                     new DocumentStatus
                     {
                         DocumentStatus_EN = "DocumentStatus2 English",
                         DocumentStatus_FR = "DocumentStatus2 French"
                     }
                );
                context.SaveChanges();

                //Seed Security lassification Data
                context.SecurityClassifications.AddRange(
                     new SecurityClassification
                     {
                         SecurityClassification_EN = "SecurityClassification1 English",
                         SecurityClassification_FR = "SecurityClassification1 French"
                     },

                    new SecurityClassification
                    {
                        SecurityClassification_EN = "SecurityClassification2 English",
                        SecurityClassification_FR = "SecurityClassification2 French"
                    }
                );
                context.SaveChanges();

                //Seed Questionnaire Data
                context.Questionnaires.AddRange(
                     new Questionnaire
                     {
                         Template = "Template Text 1",
                         DocumentTitle = "Document Title 1",
                         BusinessLineId = 3,
                         DocumentTypeId = 1,
                         DocumentStatusId = 1,
                         SecurityClassificationId = 1,
                         CreatedOn = DateTime.Parse("2021-06-07"),
                         ModifiedOn = DateTime.Parse("2021-06-07"),
                         CreatedBy = "RBOSH",
                         ModifiedBy = "RBOSH",
                         ActiveStatus = true,
                         DocumentVersion = 1,
                         EffectiveDate = DateTime.Parse("1989-1-11"),
                         ChangeSummary = "Change Summary Text 1",
                         OrganisationAccessibility = true,
                         ParentId = 0
                     },

                    new Questionnaire
                    {
                        Template = "Template Text 2",
                        DocumentTitle = "Document Title 2",
                        BusinessLineId = 4,
                        DocumentTypeId = 2,
                        DocumentStatusId = 2,
                        SecurityClassificationId = 2,
                        CreatedOn = DateTime.Parse("2021-06-07"),
                        ModifiedOn = DateTime.Parse("2021-06-07"),
                        CreatedBy = "RBOSH",
                        ModifiedBy = "RBOSH",
                        ActiveStatus = true,
                        DocumentVersion = 1,
                        EffectiveDate = DateTime.Parse("1989-1-11"),
                        ChangeSummary = "Change Summary Text 2",
                        OrganisationAccessibility = true,
                        ParentId = 0
                    }
                );
                context.SaveChanges();
            }
        }

        public static void Initialize(QuestionnaireContext context)
        {

            // Look for any movies.
            if (context.Questionnaires.Any())
            {
                return;   // DB has been seeded
            }

            
            //Seed Business Line Data
            context.BusinessLines.AddRange(
                 new BusinessLine
                 {
                     BusinessName_EN = "BusinessLine1 English",
                     BusinessName_FR = "BusinessLine1 French",
                     Abbreviation_EN = "BL1_En",
                     Abbreviation_FR = "BL1_Fr"
                 },

                 new BusinessLine
                 {
                     BusinessName_EN = "BusinessLine2 English",
                     BusinessName_FR = "BusinessLine2 French",
                     Abbreviation_EN = "BL2_En",
                     Abbreviation_FR = "BL2_Fr"
                 }
            );
            context.SaveChanges();

            //Seed Document Types Data
            context.DocumentTypes.AddRange(
                 new DocumentType
                 {
                     DocumentType_EN = "DocumentType1 English",
                     DocumentType_FR = "DocumentType1 French"
                 },

                 new DocumentType
                 {
                     DocumentType_EN = "DocumentType2 English",
                     DocumentType_FR = "DocumentType2 French"
                 }
            );
            context.SaveChanges();

            //Seed Document Status Data
            context.DocumentStatus.AddRange(
                 new DocumentStatus
                 {
                     DocumentStatus_EN = "DocumentStatus1 English",
                     DocumentStatus_FR = "DocumentStatus1 French"
                 },

                 new DocumentStatus
                 {
                     DocumentStatus_EN = "DocumentStatus2 English",
                     DocumentStatus_FR = "DocumentStatus2 French"
                 }
            );
            context.SaveChanges();

            //Seed Security lassification Data
            context.SecurityClassifications.AddRange(
                 new SecurityClassification
                 {
                     SecurityClassification_EN = "SecurityClassification1 English",
                     SecurityClassification_FR = "SecurityClassification1 French"
                 },

                new SecurityClassification
                {
                    SecurityClassification_EN = "SecurityClassification2 English",
                    SecurityClassification_FR = "SecurityClassification2 French"
                }
            );
            context.SaveChanges();

            //Seed Questionnaire Data
            context.Questionnaires.AddRange(
                 new Questionnaire
                 {
                     Template = "Template Text 1",
                     DocumentTitle = "Document Title 1",
                     BusinessLineId = 3,
                     DocumentTypeId = 1,
                     DocumentStatusId = 1,
                     SecurityClassificationId = 1,
                     CreatedOn = DateTime.Parse("2021-06-07"),
                     ModifiedOn = DateTime.Parse("2021-06-07"),
                     CreatedBy = "RBOSH",
                     ModifiedBy = "RBOSH",
                     ActiveStatus = true,
                     DocumentVersion = 1,
                     EffectiveDate = DateTime.Parse("1989-1-11"),
                     ChangeSummary = "Change Summary Text 1",
                     OrganisationAccessibility = true,
                     ParentId = 0
                 },

                new Questionnaire
                {
                    Template = "Template Text 2",
                    DocumentTitle = "Document Title 2",
                    BusinessLineId = 4,
                    DocumentTypeId = 2,
                    DocumentStatusId = 2,
                    SecurityClassificationId = 2,
                    CreatedOn = DateTime.Parse("2021-06-07"),
                    ModifiedOn = DateTime.Parse("2021-06-07"),
                    CreatedBy = "RBOSH",
                    ModifiedBy = "RBOSH",
                    ActiveStatus = true,
                    DocumentVersion = 1,
                    EffectiveDate = DateTime.Parse("1989-1-11"),
                    ChangeSummary = "Change Summary Text 2",
                    OrganisationAccessibility = true,
                    ParentId = 0
                }
            );
            context.SaveChanges();
        }
    }
}    
    


