using DTOs.Brand;
using MediatR;

namespace Application.Features.Brands.Queries.GetBrandDetails
{
    public class GetBrandDetailsQuery : IRequest<BrandLargeDto>
    {
        public int Id { get; set; }
        public GetBrandDetailsQuery(int id)
        {
            Id = id;
        }
    }
}
