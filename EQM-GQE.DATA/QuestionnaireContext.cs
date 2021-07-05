using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;
using Microsoft.EntityFrameworkCore;

namespace EQM_GQE.DATA
{
    public class QuestionnaireContext : DbContext, IQuestionnaireContext
    {
        public QuestionnaireContext(DbContextOptions<QuestionnaireContext> options) : base(options) {}
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<BusinessLine> BusinessLines { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<DocumentStatus> DocumentStatus { get; set; }
        public DbSet<SecurityClassification> SecurityClassifications { get; set; }
        public DbSet<BusinessLineAccessControl> BusinessLineAccessControl { get; set; }

    }
}