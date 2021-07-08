using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Description).NotNull().WithMessage("boş geçilemez");
            RuleFor(c => c.Description).Length(3, 200)
                .WithMessage("10 ve 200 arasında karakter içermeli");
            RuleFor(c => c.Name).NotNull().WithMessage("Boş geçilemez");
            RuleFor(c => c.Name).Length(4, 50).WithMessage("4-50 arasında karakter içermeli");

        }
    }
}
