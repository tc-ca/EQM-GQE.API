﻿using System;
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
                Id = index,
                DateCreated = DateTime.Now.AddDays(index),
                Template = Templates[rng.Next(Templates.Length)]
            })
            .ToArray();
        }
    }
}