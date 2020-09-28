using Domain.Repository.Brand;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Brand.Commands.Handlers
{

    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand>
    {
        private readonly IBrandRepository _brandRepository;

        public UpdateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task<Unit> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.GetById(request.Id);

            brand.Name = request.Name;

            await _brandRepository.Update(brand);

            return Unit.Value;
        }
    }
}
