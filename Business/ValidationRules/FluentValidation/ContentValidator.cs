using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class ContentValidator:AbstractValidator<Content>
   {
       public ContentValidator()
       {
           RuleFor(c => c.ContentValue).NotNull().MaximumLength(1000);

       }
    }
}
