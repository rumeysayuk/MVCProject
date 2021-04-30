using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.WriterName).NotNull().Length(3, 50);
            RuleFor(w => w.WriterSurname).NotNull().Length(3, 50);
            RuleFor(w => w.WriterImage).MaximumLength(100);
            RuleFor(w => w.WriterMail).NotNull().EmailAddress();
            RuleFor(w => w.WriterPassword).NotNull().Length(6, 50);

        }
    }
}
