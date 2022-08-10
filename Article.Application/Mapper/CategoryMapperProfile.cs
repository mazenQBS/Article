using Article.Domain.Dto;
using Article.Domain.Entity;
using AutoMapper;

namespace Article.Application.Mapper;

public class CategoryMapperProfile : Profile

{
    public CategoryMapperProfile()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
    }
}