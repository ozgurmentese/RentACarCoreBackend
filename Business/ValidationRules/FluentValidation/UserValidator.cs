using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u => u.FirstName).MinimumLength(2);
            RuleFor(u => u.Email).NotEmpty();
        }
    }
}
