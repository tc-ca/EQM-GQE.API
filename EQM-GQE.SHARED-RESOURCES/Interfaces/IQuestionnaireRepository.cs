using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Models;

namespace EQM_GQE.SHARED_RESOURCES.Interfaces
{
    public interface IQuestionnaireRepository
    {
        Task<long> Add(Questionnaire Questionnaire);

        Task<bool> Update(Questionnaire Questionnaire);

        Questionnaire Get(int id);

        Task<List<Questionnaire>> GetAllAsync();
    }
}
