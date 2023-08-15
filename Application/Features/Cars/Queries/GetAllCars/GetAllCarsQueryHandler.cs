using Application.Contracts.Cars;
using DTOs.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Queries.GetAllCars
{
    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<CarLargDTO>>
    {
        private readonly ICarRepository _carRepository;

        public GetAllCarsQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<IEnumerable<CarLargDTO>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            return (await _carRepository.FilterByAsync()).Select(c => new CarLargDTO()
            {
                Id = c.Id,
                ModelName = c.ModelName,
                ModelType = c.ModelType,
                ModelYear = c.ModelYear,
                Power = c.Power,
                BrandName=c.Brand.Name

            });
        }
    }
}
