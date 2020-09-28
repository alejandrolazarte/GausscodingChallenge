using Domain.Repository.Brand;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Brand.Commands.Handlers
{
    public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommand>
    {
        private readonly IBrandRepository _brandRepository;

        public DeleteBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task<Unit> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.GetById(request.Id);

            await _brandRepository.Delete(brand);

            return Unit.Value;
        }
    }
}
