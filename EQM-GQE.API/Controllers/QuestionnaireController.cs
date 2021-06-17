using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EQM_GQE.SHARED_RESOURCES.Models;
using EQM_GQE.LOGICAL;
using EQM_GQE.SHARED_RESOURCES.Interfaces;

namespace EQM_GQE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionnaireController : ControllerBase
    {     
        private readonly IQuestionnaireLogic _questionnaireLogic;

        public QuestionnaireController(IQuestionnaireLogic questionnaireLogic)
        {
            _questionnaireLogic = questionnaireLogic;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var result = _questionnaireLogic.Get(id);
            if (result == null)
            {
                return Ok("No template found");
            }

            return Ok(result);
        }

        [HttpPost]        
        public async Task<ActionResult> CreateQuestionnaire(Questionnaire oQuestionnaire)
        {
            var result = await _questionnaireLogic.Add(oQuestionnaire);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPut("{id}")]      
        public async Task<ActionResult> UpdateQuestionnaire(Questionnaire Questionnaire, long id)
        {
            if (id != Questionnaire.Id)
            {
                return BadRequest();
            }
            return await _questionnaireLogic.Update(Questionnaire) ? Ok() : BadRequest();
          
        }
    }
}
