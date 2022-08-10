using Article.Domain.Dto;
using AutoMapper;

namespace Article.Application.Mapper;
using Domain.Entity;
public class ArticleMapperProfile : Profile
{
    public ArticleMapperProfile()
    {
        CreateMap<Article, ArticleDto>()
            .ForMember(
                a => a.CategoryName
                , option =>
                    option.MapFrom(a => a.Category!.CategoryName)
                    )
            .ReverseMap();
    }


}