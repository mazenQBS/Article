using Article.Domain.Entity;
using FluentValidation;

namespace Article.Application.Validator;

public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(cat => cat.CategoryName).NotEmpty().NotNull();
        RuleFor(cat => cat.IsActive).NotEmpty().NotNull();

    }
}