using MediatR;
using Microsoft.AspNetCore.Mvc;
using PocAdmin.Core.Entities;
using PocAdmin.Core.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PocAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileEventController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FileEventController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("ByReferenceId/{referenceId}")]
        public async Task<ActionResult<IEnumerable<FileEvent>>> GetFileEventsByReferenceId(string referenceId)
        {
            return Ok(await _mediator.Send(new GetFileEventsByReferenceIdQuery(referenceId)));
        }
    }
}
