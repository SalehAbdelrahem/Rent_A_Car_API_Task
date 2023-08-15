using Application.Features.MasterDetails.Commands.CreateMasterDetail;
using Application.Features.Nationalities.Queries.GetAllNationalities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPiTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MasterDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateMasterDetail")]

        public async Task<IActionResult> CreateMasterDetail([FromBody] CreateMasterDetailCommand com)
        {
            return Ok(await _mediator.Send(com));
        }
    }
}
