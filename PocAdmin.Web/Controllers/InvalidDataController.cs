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
    public class InvalidDataController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InvalidDataController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvalidData>>> GetAllInvalidData()
        {
            return Ok(await _mediator.Send(new GetAllInvalidDataQuery()));
        }
    }
}
