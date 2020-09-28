using Application.Product.DTOs;
using MediatR;
using System.Collections.Generic;

namespace Application.Product.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>> 
    {
        public string Search { get; set; }
    }
}
