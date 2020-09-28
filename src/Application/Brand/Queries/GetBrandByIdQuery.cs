using Application.Brand.DTOs;
using MediatR;

namespace Application.Brand.Queries
{
    public class GetBrandByIdQuery : IRequest<BrandDto>
    {
        public long Id { get; }

        public GetBrandByIdQuery(long id)
        {
            Id = id;
        }
    }
}
