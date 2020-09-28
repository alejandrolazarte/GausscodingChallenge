using Application.Brand.DTOs;
using AutoMapper;
using Domain.Repository.Brand;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Brand.Queries.Handlers
{

    public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQuery, IEnumerable<BrandDto>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetAllBrandsQueryHandler(IBrandRepository brandRepository,
            IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BrandDto>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var brands = await _brandRepository.GetByFilter(x => x.Name.Contains(request.Search));
            return _mapper.Map<IEnumerable<BrandDto>>(brands);
        }
    }
}
