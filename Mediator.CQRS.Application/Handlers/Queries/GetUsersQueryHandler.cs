using Mediator.CQRS.Interfaces;
using Mediator.CQRS.Models;
using Mediator.CQRS.Queries;
using MediatR;

namespace Mediator.CQRS.Handlers.Queries
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<User>>
    {
        private readonly IUserService userService;

        public GetUsersQueryHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<List<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(userService.GetUsers());
        }
    }
}
