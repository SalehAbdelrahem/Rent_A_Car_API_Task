using Application.Contracts;
using DTOs.Brand;
using MediatR;

namespace Application.Features.Brands.Queries.FilterBrands
{
    public class FilterBrandQueryHandler : IRequestHandler<FilterBrandQuery, IEnumerable<BrandDTO>>
    {
        private readonly IBrandRepository _brandRepository;

        public FilterBrandQueryHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task<IEnumerable<BrandDTO>> Handle(FilterBrandQuery request, CancellationToken cancellationToken)
        {
            var brands = await _brandRepository.GetAllAsync();
            if (brands is not null)
            {
                return (await _brandRepository.FilterByAsync(request.filter))
                .Select(brand => new BrandDTO() { Id = brand.Id, Name = brand.Name });
            }
            else throw new Exception("Not Found Any Brand");
            
        }
    }
}
