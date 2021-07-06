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
    public class DocumentStatusController : ControllerBase
    {
        private readonly IDocumentStatusLogic _documentStatusLogic;

        public DocumentStatusController(IDocumentStatusLogic documentStatusLogic)
        {
            _documentStatusLogic = documentStatusLogic;
        }

        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            var result = _documentStatusLogic.Get(id);
            if (result == null)
            {
                return BadRequest("Status not found");
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<DocumentStatus>>> GetAll()
        {
            var result = await _documentStatusLogic.GetAllAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpGet("active")]
        public async Task<ActionResult<List<DocumentStatus>>> GetAllActive()
        {
            var result = await _documentStatusLogic.GetAllActiveAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }



        [HttpPost]
        public async Task<ActionResult> CreateQuestionnaire(DocumentStatus documentStatus)
        {
            var result = await _documentStatusLogic.Add(documentStatus);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateQuestionnaire(DocumentStatus documentStatus, int id)
        {
            if (id != documentStatus.DocumentStatusId)
            {
                return BadRequest();
            }
            return await _documentStatusLogic.Update(documentStatus) ? Ok() : BadRequest();

        }
    }
}