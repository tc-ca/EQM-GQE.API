using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EQM_GQE.DATA.Repositories
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private readonly IQuestionnaireContext _context;

        public QuestionnaireRepository(IQuestionnaireContext context)
        {
            _context  = context;
        }

        public async Task<long> Add(Questionnaire questionnaire)
        {
            await _context.Questionnaires.AddAsync(questionnaire, CancellationToken.None);
            await _context.SaveChangesAsync(CancellationToken.None);
            return questionnaire.Id;
        }
        public async Task<long> Update(Questionnaire questionnaire)
        {
            _context.Questionnaires.Update(questionnaire);
            await _context.SaveChangesAsync(CancellationToken.None);
            return questionnaire.Id;
        }
    }
}


