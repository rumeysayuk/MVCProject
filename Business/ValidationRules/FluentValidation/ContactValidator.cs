using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.Username).NotNull().Length(3, 50);
            RuleFor(c => c.UserMail).NotNull().EmailAddress();
            RuleFor(c => c.Subject).NotNull().Length(5, 50);
        }
    }
}
