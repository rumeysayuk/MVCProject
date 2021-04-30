using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
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
