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
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumentTypeLogic _documentTypeLogic;

        public DocumentTypeController(IDocumentTypeLogic documentTypeLogic)
        {
            _documentTypeLogic = documentTypeLogic;
        }
        
        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            var result = _documentTypeLogic.Get(id);
            if (result == null)
                return BadRequest("Template not found");
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<List<DocumentType>>> GetAll()
        {
            var result = await _documentTypeLogic.GetAllAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpGet("active")]
        public async Task<ActionResult<List<DocumentType>>> GetAllActive()
        {
            var result = await _documentTypeLogic.GetAllActiveAsync();
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}