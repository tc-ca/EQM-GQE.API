using EQM_GQE.SHARED_RESOURCES.Interfaces;
using EQM_GQE.SHARED_RESOURCES.Models;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

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

        public async Task<bool> Update(Questionnaire Questionnaire)
        {
            _context.Questionnaires.Update(Questionnaire);
            await _context.SaveChangesAsync(CancellationToken.None);
            return true;               
        }

        public Questionnaire Get(int id)
        {
            var result = _context.Questionnaires.FirstOrDefault(o => o.Id == id);
            return result;
        }
    }
}


