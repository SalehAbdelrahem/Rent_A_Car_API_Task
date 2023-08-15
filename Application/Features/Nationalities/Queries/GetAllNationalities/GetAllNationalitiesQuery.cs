using DTOs.Nationalities;
using MediatR;

namespace Application.Features.Nationalities.Queries.GetAllNationalities
{
    public class GetAllNationalitiesQuery : IRequest<IEnumerable<NationalityDTO>>
    {
    }
}
