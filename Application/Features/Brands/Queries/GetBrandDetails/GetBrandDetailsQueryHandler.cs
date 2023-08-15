using Application.Contracts;
using Domain;
using DTOs.Brand;
using DTOs.Cars;
using MediatR;

namespace Application.Features.Brands.Queries.GetBrandDetails
{
    public class GetBrandDetailsQueryHandler : IRequestHandler<GetBrandDetailsQuery, BrandLargeDto>
    {
        private readonly IBrandRepository _brandRepository;
      
        public GetBrandDetailsQueryHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
           
        }
        public async Task<BrandLargeDto> Handle(GetBrandDetailsQuery request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.GetDetailsAsync(request.Id);

            if (brand == null)
            {
               throw new Exception($"NO brand with This Id {request.Id}");
            }

            else
            {
                BrandLargeDto p = new BrandLargeDto
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    CarsDTO = brand.Cars.Select(c => new CarDTO()
                    {
                        Id = c.Id,
                        ModelName = c.ModelName,
                        ModelType = c.ModelType,
                        ModelYear = c.ModelYear,
                        Power = c.Power
                    }).ToList()
                    
                   
                };

               
               

                return p;

            }
        }
    }
}
