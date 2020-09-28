using Domain.Repository.Product;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Product.Commands.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(request.Id);

            product.Name = request.Name;
            product.Cost = request.Cost;
            product.Price = request.Price;
            product.BrandId = request.BrandId;

            await _productRepository.Update(product);

            return Unit.Value;
        }
    }
}
