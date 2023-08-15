using Application.Contracts.Nationalities;
using DTOs.Nationalities;
using MediatR;

namespace Application.Features.Nationalities.Queries.GetAllNationalities
{
    public class GetAllNationalitiesQueryHandler : IRequestHandler<GetAllNationalitiesQuery, IEnumerable<NationalityDTO>>
    {
        private readonly INationalitiyRepository _nationalitiyRepository;

        public GetAllNationalitiesQueryHandler(INationalitiyRepository nationalitiyRepository)
        {
            _nationalitiyRepository = nationalitiyRepository;
        }
        public async Task<IEnumerable<NationalityDTO>> Handle(GetAllNationalitiesQuery request, CancellationToken cancellationToken)
        {
            var Nationalites = await _nationalitiyRepository.GetAllAsync();
            if (Nationalites is  null)
            {
                throw new Exception("Not Found Any  Nationality");
            }
            else
            {
                return Nationalites.Select(x => new NationalityDTO()
                {
                    Id = x.Id,
                    Name = x.Name
                });
            }
           
        }
    }
}
