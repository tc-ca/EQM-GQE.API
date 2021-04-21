using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EQM_GQE.API.Models;
using Microsoft.Extensions.Configuration;

namespace EQM_GQE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionnaireController : ControllerBase
    {
        // Sample data
        private static readonly string[] Templates = new[]
        {
            "{ 'pages': [ { 'name': 'page1', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page2', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page3', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page4', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page5', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page6', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page7', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page8', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page9', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page10', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }" 
        };

        private readonly ILogger<QuestionnaireController> _logger;
        private readonly IConfiguration _configuration;

        public QuestionnaireController(ILogger<QuestionnaireController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Questionnaire> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Questionnaire
            {
                Id = index,
                DateCreated = DateTime.Now.AddDays(index),
                Template = _configuration["eqmgqepostgresqlConnectionString"] //Templates[rng.Next(Templates.Length)],
            })
            .ToArray();
        }
    }
}
