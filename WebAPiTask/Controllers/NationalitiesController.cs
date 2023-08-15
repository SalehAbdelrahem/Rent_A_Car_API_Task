using Application.Features.Nationalities.Queries.GetAllNationalities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPiTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class NationalitiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NationalitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("AllNationalities")]

        public async Task<IActionResult> GetAllNationalities([FromQuery] GetAllNationalitiesQuery com)
        {
            return Ok(await _mediator.Send(com));
        }
    }
}