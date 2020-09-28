using Application.Brand.DTOs;
using MediatR;
using System.Collections.Generic;

namespace Application.Brand.Queries
{
    public class GetAllBrandsQuery : IRequest<IEnumerable<BrandDto>> 
    {
        public string Search { get; set; }
    }
}
