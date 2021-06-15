using EQM_GQE.SHARED_RESOURCES.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EQM_GQE.DATA
{
    public interface IQuestionnaireContext
    {
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<BusinessLine> BusinessLines { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<DocumentStatus> DocumentStatus { get; set; }
        public DbSet<SecurityClassification> SecurityClassifications { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
