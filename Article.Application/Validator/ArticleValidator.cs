using FluentValidation;

namespace Article.Application.Validator;
using Domain.Entity;
public class ArticleValidator : AbstractValidator<Article>
{
    public ArticleValidator()
    {
        RuleFor(art => art.Title).NotEmpty().NotNull();
        RuleFor(art => art.Data).NotEmpty().NotNull();
        RuleFor(art => art.Body).NotEmpty().NotNull();
        RuleFor(art => art.IsActive).NotEmpty().NotNull();
        RuleFor(art => art.IsApproved).NotEmpty().NotNull();
        RuleFor(art => art.Category)
            .SetValidator(new CategoryValidator()!);

    }

}