using Application.Product.DTOs;
using MediatR;

namespace Application.Product.Queries
{
    public class GetProductByIdQuery : IRequest<ProductDto>
    {
        public long Id { get; }

        public GetProductByIdQuery(long id)
        {
            Id = id;
        }
    }
}
