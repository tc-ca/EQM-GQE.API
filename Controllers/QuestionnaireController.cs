using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EQM_GQE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionnaireController : ControllerBase
    {
        private static readonly string[] Templates = new[]
        {
            "{ 'pages': [ { 'name': 'Questionnaire 1' } ] }", 
            "{ 'pages': [ { 'name': 'Questionnaire 2' } ] }", 
            "{ 'pages': [ { 'name': 'Questionnaire 3' } ] }", 
            "{ 'pages': [ { 'name': 'Questionnaire 4' } ] }", 
            "{ 'pages': [ { 'name': 'Questionnaire 5' } ] }", 
            "{ 'pages': [ { 'name': 'Questionnaire 6' } ] }", 
        };

        private readonly ILogger<QuestionnaireController> _logger;

        public QuestionnaireController(ILogger<QuestionnaireController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Questionnaire> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Questionnaire
            {
                Id = Guid.NewGuid(),
                DateCreated = DateTime.Now.AddDays(index),
                Template = Templates[rng.Next(Templates.Length)]
            })
            .ToArray();
        }
    }
}
