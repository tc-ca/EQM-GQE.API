using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EQM_GQE.API.Models;

namespace EQM_GQE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionnaireController : ControllerBase
    {
        private readonly ILogger<QuestionnaireController> _logger;
        private readonly QuestionnaireContext _context;

        public QuestionnaireController(ILogger<QuestionnaireController> logger, QuestionnaireContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Questionnaire>> GetAll()
        {
            return _context.Questionnaires.ToList();
        }

        [HttpGet("{id}", Name = "GetQuestionnaire")]
        public ActionResult<Questionnaire> GetById(long id)
        {
            var questionnaire = _context.Questionnaires.Find(id);
            if (questionnaire == null) {
                return NotFound();
            }
            return questionnaire;
        }
    }
}
