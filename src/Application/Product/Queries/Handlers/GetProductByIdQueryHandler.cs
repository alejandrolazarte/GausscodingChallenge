using Application.Product.DTOs;
using AutoMapper;
using Domain.Repository.Product;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Product.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(request.Id);

            if(product == null) 
            {
                throw new ArgumentNullException(nameof(product));
            }

            return _mapper.Map<ProductDto>(product);
        }
    }
}
