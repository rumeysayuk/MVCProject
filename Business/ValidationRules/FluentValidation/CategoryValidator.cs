using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryDescription).NotNull().WithMessage("boş geçilemez");
            RuleFor(c => c.CategoryDescription).Length(10, 200)
                .WithMessage("10 ve 200 arasında karakter içermeli");
            RuleFor(c => c.CategoryName).NotNull().WithMessage("Boş geçilemez");
            RuleFor(c => c.CategoryName).Length(4, 50).WithMessage("4-50 arasında karakter içermeli");

        }
    }
}
