using Domain.Repository.Brand;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Brand.Commands.Handlers
{

    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, long>
    {
        private readonly IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<long> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = new Domain.Entities.Brand() 
            { 
                Name = request.Name 
            };

            await _brandRepository.Add(brand);

            return brand.Id;
        }
    }
}
