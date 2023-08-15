using Application.Contracts.Cars;
using DTOs.Cars;
using MediatR;

namespace Application.Features.Cars.Queries.FilterCars
{
    public class FilterCarsQueryHandler : IRequestHandler<FilterCarsQuery, IEnumerable<CarLargDTO>>
    {
        private readonly ICarRepository _carRepository;

        public FilterCarsQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<IEnumerable<CarLargDTO>> Handle(FilterCarsQuery request, CancellationToken cancellationToken)
        {
            return (await _carRepository.FilterByAsync(request.ModelName, request.BrandName,request.ModelYear)).Select(c=>new CarLargDTO()
            {
                Id = c.Id,
                ModelName = c.ModelName,
                ModelType = c.ModelType,
                ModelYear = c.ModelYear,
                Power = c.Power,
                BrandName = c.Brand.Name

            });
        }
    }
}
