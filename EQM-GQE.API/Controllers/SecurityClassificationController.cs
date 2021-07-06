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
    public class SecurityClassificationController : ControllerBase
    {
        private readonly ISecurityClassificationLogic _securityClassificationLogic;

        public SecurityClassificationController(ISecurityClassificationLogic securityClassificationLogic)
        {
            _securityClassificationLogic = securityClassificationLogic;
        }

        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            var result = _securityClassificationLogic.Get(id);
            if (result == null)
            {
                return BadRequest("Security classification not found");
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<SecurityClassification>>> GetAll()
        {
            var result = await _securityClassificationLogic.GetAllAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpGet("active")]
        public async Task<ActionResult<List<SecurityClassification>>> GetAllActive()
        {
            var result = await _securityClassificationLogic.GetAllActiveAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }



        [HttpPost]
        public async Task<ActionResult> CreateSecurityClassification(SecurityClassification securityClassification)
        {
            var result = await _securityClassificationLogic.Add(securityClassification);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSecurityClassification(SecurityClassification securityClassification, int id)
        {
            if (id != securityClassification.SecurityClassificationId)
            {
                return BadRequest();
            }
            return await _securityClassificationLogic.Update(securityClassification) ? Ok() : BadRequest();

        }
    }
}