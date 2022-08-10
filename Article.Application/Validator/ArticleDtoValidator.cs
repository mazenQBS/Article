using Article.Domain.Dto;
using FluentValidation;

namespace Article.Application.Validator;

public class ArticleDtoValidator : AbstractValidator<ArticleDto>
{
    public ArticleDtoValidator()
    {
        RuleFor(artDto => artDto.Body).NotEmpty().NotNull();
        RuleFor(artDto => artDto.Data).NotEmpty().NotNull();
        RuleFor(artDto => artDto.CategoryName).NotEmpty().NotNull();
        RuleFor(artDto => artDto.Title).NotEmpty().NotNull();
    }
}