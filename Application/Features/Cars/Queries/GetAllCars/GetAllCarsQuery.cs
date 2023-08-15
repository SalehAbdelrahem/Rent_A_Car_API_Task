using DTOs.Cars;
using MediatR;

namespace Application.Features.Cars.Queries.GetAllCars
{
    public class GetAllCarsQuery : IRequest<IEnumerable<CarLargDTO>>
    {
    }
}
