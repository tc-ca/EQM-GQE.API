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
    public class BusinessLineAccessControlController : ControllerBase
    {
        private readonly IBusinessLineAccessControlLogic _accessControlLogic;
        public BusinessLineAccessControlController(IBusinessLineAccessControlLogic accessControlLogic)
        {
            _accessControlLogic = accessControlLogic;
        }

        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            var result = _accessControlLogic.Get(id);
            if (result == null)
            {
                return BadRequest("User not found");
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<BusinessLineAccessControl>>> GetAll()
        {
            var result = await _accessControlLogic.GetAllAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpGet("active")]
        public async Task<ActionResult<List<BusinessLineAccessControl>>> GetAllActive()
        {
            var result = await _accessControlLogic.GetAllActiveAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }



        [HttpPost]
        public async Task<ActionResult> CreateAccessControl(BusinessLineAccessControl accessControl)
        {
            var result = await _accessControlLogic.Add(accessControl);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateQuestionnaire(BusinessLineAccessControl accessControl, int id)
        {
            if (id != accessControl.Id)
            {
                return BadRequest();
            }
            return await _accessControlLogic.Update(accessControl) ? Ok() : BadRequest();

        }
    }
}
