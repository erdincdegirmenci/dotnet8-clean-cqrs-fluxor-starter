using CQRS.Project.Features.Commands;
using CQRS.Project.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediumController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MediumController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var mediums = await _mediator.Send(new GetMediumQuery());
            return Ok(mediums);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMediumCommand command)
        {
            var success = await _mediator.Send(command);
            if (success) 
                return Ok();
            return BadRequest();
        }
    }


}
