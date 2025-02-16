using FluentValidation;
using Mediator.CQRS.Commands;

namespace Mediator.CQRS.Validations
{
    public class AddUserCommandValidator : AbstractValidator<AddUserCommand>
    {
        public AddUserCommandValidator() 
        {
            RuleFor(x=>x.Id).NotEqual(0);
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x=>x.Email).NotEmpty()
                .EmailAddress();

        }
    }
}
