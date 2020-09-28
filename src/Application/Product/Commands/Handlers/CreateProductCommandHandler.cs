using Domain.Repository.Product;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Product.Commands.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, long>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<long> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Domain.Entities.Product()
            {
                Name = request.Name,
                Cost = request.Cost,
                Price = request.Price,
                BrandId = request.BrandId,
            };

            await _productRepository.Add(product);

            return product.Id;
        }
    }
}
