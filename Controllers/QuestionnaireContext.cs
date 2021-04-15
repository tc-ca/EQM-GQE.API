using Microsoft.EntityFrameworkCore;

namespace EQM_GQE.API.Models
{
    public class QuestionnaireContext : DbContext
    {
        public QuestionnaireContext(DbContextOptions<QuestionnaireContext> options) : base(options) {}
        public DbSet<Questionnaire> Questionnaires { get; set; }
    }
}