using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Linq;

namespace EQM_GQE.DATA
{
    public static class SeedData
    {        
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
                     BusinessName_EN = "Aviation Security",
                     BusinessName_FR = "Sûreté de l'aviation",
                     Abbreviation_EN = "",
                     Abbreviation_FR = ""
                 },

                 new BusinessLine
                 {
                     BusinessName_EN = "Intermodal Surface Security Oversight",
                     BusinessName_FR = "Surveillance de la sécurité intermodale de surface",
                     Abbreviation_EN = "",
                     Abbreviation_FR = ""
                 },

                new BusinessLine
                {
                    BusinessName_EN = "Transportation of Dangerous Goods",
                    BusinessName_FR = "Transport des marchandises dangereuses",
                    Abbreviation_EN = "",
                    Abbreviation_FR = ""
                }
            );
            context.SaveChanges();

            //Seed Document Types Data
            context.DocumentTypes.AddRange(
                 new DocumentType
                 {
                     DocumentType_EN = "Inspection",
                     DocumentType_FR = "Inspection"
                 }
            );
            context.SaveChanges();

            //Seed Document Status Data
            context.DocumentStatus.AddRange(
                 new DocumentStatus
                 {
                     DocumentStatus_EN = "Draft",
                     DocumentStatus_FR = "Projet :"
                 },

                 new DocumentStatus
                 {
                     DocumentStatus_EN = "Published",
                     DocumentStatus_FR = "Publié sur"
                 }
            );
            context.SaveChanges();

            //Seed Security lassification Data
            context.SecurityClassifications.AddRange(
                 new SecurityClassification
                 {
                     SecurityClassification_EN = "Unclassified",
                     SecurityClassification_FR = "Non classifié"
                 },

                new SecurityClassification
                {
                    SecurityClassification_EN = "Protected A",
                    SecurityClassification_FR = "Protégé A"
                },

                new SecurityClassification
                {
                    SecurityClassification_EN = "Protected B",
                    SecurityClassification_FR = "Protégé B"
                }
            );
            context.SaveChanges();

            //Seed Questionnaire Data
            //context.Questionnaires.AddRange(
            //     new Questionnaire
            //     {
            //         Template = "Template Text 1",
            //         DocumentTitle = "Document Title 1",
            //         BusinessLineId = 3,
            //         DocumentTypeId = 1,
            //         DocumentStatusId = 1,
            //         SecurityClassificationId = 1,
            //         CreatedOn = DateTime.Parse("2021-06-07"),
            //         ModifiedOn = DateTime.Parse("2021-06-07"),
            //         CreatedBy = "RBOSH",
            //         ModifiedBy = "RBOSH",
            //         ActiveStatus = true,
            //         DocumentVersion = 1,
            //         EffectiveDate = DateTime.Parse("1989-1-11"),
            //         ChangeSummary = "Change Summary Text 1",
            //         OrganisationAccessibility = true,
            //         ParentId = 0
            //     },

            //    new Questionnaire
            //    {
            //        Template = "Template Text 2",
            //        DocumentTitle = "Document Title 2",
            //        BusinessLineId = 4,
            //        DocumentTypeId = 2,
            //        DocumentStatusId = 2,
            //        SecurityClassificationId = 2,
            //        CreatedOn = DateTime.Parse("2021-06-07"),
            //        ModifiedOn = DateTime.Parse("2021-06-07"),
            //        CreatedBy = "RBOSH",
            //        ModifiedBy = "RBOSH",
            //        ActiveStatus = true,
            //        DocumentVersion = 1,
            //        EffectiveDate = DateTime.Parse("1989-1-11"),
            //        ChangeSummary = "Change Summary Text 2",
            //        OrganisationAccessibility = true,
            //        ParentId = 0
            //    }
            //);
            //context.SaveChanges();
        }
    }
}    
    


