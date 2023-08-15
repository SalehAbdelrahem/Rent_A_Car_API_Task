using DTOs.Cars;
using MediatR;

namespace Application.Features.Cars.Queries.FilterCars
{
    public class FilterCarsQuery:IRequest<IEnumerable<CarLargDTO>>
    {
        public string? BrandName { get; set; }
        public string? ModelName { get; set; }
        public DateTime? ModelYear { get; set; }

    }
}
