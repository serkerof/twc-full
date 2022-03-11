using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CommenterValidator : AbstractValidator<Commenter>
    {
        public CommenterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Boş ola bilməz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Boş ola bilməz");
            RuleFor(x => x.ID).NotEmpty().WithMessage("Email Boş ola bilməz");
        }
    }
}