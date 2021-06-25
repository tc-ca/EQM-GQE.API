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
    [Route("api/[controller]")]
    public class BusinessLineController : ControllerBase
    {    
         private readonly IBusinessLineLogic _businessLineLogic;

        public BusinessLineController(IBusinessLineLogic businessLineLogic)
        {
            _businessLineLogic = businessLineLogic;
        }

        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            var result = _businessLineLogic.Get(id);
            if (result == null)
            {
                return BadRequest("Template not found");
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<BusinessLine>>> GetAll()
        {
            var result = await _businessLineLogic.GetAllAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

         [HttpGet("active")]
        public async Task<ActionResult<List<BusinessLine>>> GetAllActive()
        {
            var result = await _businessLineLogic.GetAllActiveAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        

        [HttpPost]        
        public async Task<ActionResult> CreateQuestionnaire(BusinessLine businessLine)
        {
            var result = await _businessLineLogic.Add(businessLine);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPut("{id}")]      
        public async Task<ActionResult> UpdateQuestionnaire(BusinessLine businessLine, int id)
        {
            if (id != businessLine.BusinessLineId)
            {
                return BadRequest();
            }
            return await _businessLineLogic.Update(businessLine) ? Ok() : BadRequest();
          
        }
    }
}