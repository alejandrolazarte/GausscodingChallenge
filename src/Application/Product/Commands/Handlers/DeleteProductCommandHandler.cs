using Domain.Repository.Product;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Product.Commands.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(request.Id);

            await _productRepository.Delete(product);

            return Unit.Value;
        }
    }
}
