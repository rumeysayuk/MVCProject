using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryDescription).NotNull().Length(10,200);
            RuleFor(c => c.CategoryName).NotNull().Length(4,50);

        }
    }
}
