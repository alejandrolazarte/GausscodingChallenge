using Application.Brand.DTOs;
using AutoMapper;

namespace Application.MapperProfiles
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Domain.Entities.Brand, BrandDto>().ReverseMap();
        }
    }
}
