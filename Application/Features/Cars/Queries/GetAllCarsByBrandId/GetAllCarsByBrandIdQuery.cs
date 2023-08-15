using DTOs.Cars;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Queries.GetAllCarsByBrandId
{
    public class GetAllCarsByBrandIdQuery:IRequest<IEnumerable<CarDTO>>
    {
        public int BrandId { get; set; }
    }
}
