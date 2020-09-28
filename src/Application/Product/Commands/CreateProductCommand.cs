using MediatR;

namespace Application.Product.Commands
{
    public class CreateProductCommand : IRequest<long>
    {
        public string Name { get; set; }

        public decimal Cost { get; set; }

        public decimal Price { get; set; }

        public long BrandId { get; set; }
    }
}
