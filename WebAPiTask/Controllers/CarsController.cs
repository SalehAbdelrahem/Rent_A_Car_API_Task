using Application.Features.Brands.Queries.FilterBrands;
using Application.Features.Cars.Queries.FilterCars;
using Application.Features.Cars.Queries.GetAllCars;
using Application.Features.Cars.Queries.GetAllCarsByBrandId;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPiTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("SearchCar")]

        public async Task<IActionResult> FilterCars([FromQuery] FilterCarsQuery com)
        {
            return Ok(await _mediator.Send(com));
        }
        [HttpGet("AllCars")]

        public async Task<IActionResult> GetAllCars([FromQuery] GetAllCarsQuery com)
        {
            return Ok(await _mediator.Send(com));
        }

        [HttpGet("AllCarsByBrandId")]

        public async Task<IActionResult> GetAllCarsByBrandId([FromQuery] GetAllCarsByBrandIdQuery com)
        {
            return Ok(await _mediator.Send(com));
        }

    }
}
