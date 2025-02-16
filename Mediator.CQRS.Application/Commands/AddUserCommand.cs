using Mediator.CQRS.Models;
using MediatR;

namespace Mediator.CQRS.Commands
{
    public class AddUserCommand : IRequest<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public AddUserCommand(int Id , string Name , string Email)
        {
            this.Id = Id ;
            this.Name = Name ;
            this.Email = Email ;
        }
    }
}
