using MediatR;

namespace Application.Product.Commands
{
    public class UpdateProductCommand : IRequest
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public decimal Price { get; set; }

        public long BrandId { get; set; }
    }
}
