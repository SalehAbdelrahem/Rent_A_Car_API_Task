using DTOs.Brand;
using MediatR;

namespace Application.Features.Brands.Queries.FilterBrands
{
    public class FilterBrandQuery : IRequest<IEnumerable<BrandDTO>>
    {
        public string? filter { get; set; }
        public int? id { get; set; }
    }
}
