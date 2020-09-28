using Application.Product.DTOs;
using AutoMapper;

namespace Application.MapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Domain.Entities.Product, ProductDto>()
                .ForMember(dest => dest.BrandName, o => o.MapFrom(x => x.Brand != null ? x.Brand.Name : string.Empty))
                .ReverseMap();
        }
    }
}
