using Article.Domain.Dto;
using FluentValidation;

namespace Article.Application.Validator;

public class CategoryDtoValidator : AbstractValidator<CategoryDto>
{
    public CategoryDtoValidator()
    {
        RuleFor(cat => cat.CategoryName).NotEmpty().NotNull();
        RuleFor(cat => cat.IsActive).NotEmpty().NotNull();

    }
}