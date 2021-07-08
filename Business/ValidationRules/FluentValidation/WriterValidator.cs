using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.Firstname).NotNull().Length(3, 50);
            RuleFor(w => w.Lastname).NotNull().Length(3, 50);
            RuleFor(w => w.Image).MaximumLength(100);
            RuleFor(w => w.EMail).NotNull().EmailAddress();
            RuleFor(w => w.Password).NotNull().Length(6, 50);

        }
    }
}
