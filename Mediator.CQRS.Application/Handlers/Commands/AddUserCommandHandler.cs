using Mediator.CQRS.Commands;
using Mediator.CQRS.Interfaces;
using Mediator.CQRS.Models;
using MediatR;

namespace Mediator.CQRS.Handlers.Commands
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, User>
    {
        private readonly IUserService userService;

        public AddUserCommandHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.Id , request.Name,request.Email);
            return userService.AddUser(user);
        }
    }
}
