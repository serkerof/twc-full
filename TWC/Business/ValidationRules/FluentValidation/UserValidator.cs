using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Boş ola bilməz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Boş ola bilməz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Boş ola bilməz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email yalnışdır");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifrə Boş ola bilməz");
            RuleFor(x => x.Password).Length(8, 20).WithMessage("Şifrə uzunluğu 8 ilə 20 arasında olmalıdır");
            RuleFor(x => x.Password).Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,20}$").WithMessage("Şifrə 8 ilə 20 arasında olmalıdır");
        }
    }
}