using Application.Contracts.Cars;
using DTOs.Cars;
using MediatR;

namespace Application.Features.Cars.Queries.GetAllCarsByBrandId
{
    public class GetAllCarsByBrandIdQueryHandler : IRequestHandler<GetAllCarsByBrandIdQuery, IEnumerable<CarDTO>>
    {
        private readonly ICarRepository _carRepository;

        public GetAllCarsByBrandIdQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<IEnumerable<CarDTO>> Handle(GetAllCarsByBrandIdQuery request, CancellationToken cancellationToken)
        {
            return (await _carRepository.GetCarsByBrandIdAsync(request.BrandId)).Select(c => new CarDTO()
            {
                Id = c.Id,
                ModelName = c.ModelName,
                ModelType = c.ModelType,
                ModelYear = c.ModelYear,
                Power = c.Power
            });
        }
    }
}
