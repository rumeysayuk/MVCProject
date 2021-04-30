using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class ContentValidator:AbstractValidator<Content>
   {
       public ContentValidator()
       {
           RuleFor(c => c.ContentValue).NotNull().MaximumLength(1000);

       }
    }
}
