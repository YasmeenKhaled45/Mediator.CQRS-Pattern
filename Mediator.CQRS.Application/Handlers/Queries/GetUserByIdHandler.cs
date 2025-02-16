using Mediator.CQRS.Interfaces;
using Mediator.CQRS.Models;
using Mediator.CQRS.Queries;
using MediatR;

namespace Mediator.CQRS.Handlers.Queries
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserService userService;

        public GetUserByIdHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(userService.GetUserById(request.Id));
        }
    }
}
