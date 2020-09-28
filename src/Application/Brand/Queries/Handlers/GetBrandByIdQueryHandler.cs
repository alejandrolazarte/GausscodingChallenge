using Application.Brand.DTOs;
using AutoMapper;
using Domain.Repository.Brand;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Brand.Queries.Handlers
{

    public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, BrandDto>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetBrandByIdQueryHandler(IBrandRepository brandRepository,
            IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<BrandDto> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.GetById(request.Id);

            if (brand == null)
            {
                throw new ArgumentNullException(nameof(brand));
            }

            return _mapper.Map<BrandDto>(brand);
        }
    }
}
