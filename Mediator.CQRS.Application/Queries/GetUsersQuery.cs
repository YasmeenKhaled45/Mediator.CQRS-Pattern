using Mediator.CQRS.Models;
using MediatR;

namespace Mediator.CQRS.Queries
{
    public class GetUsersQuery : IRequest<List<User>>
    {

    }
}
