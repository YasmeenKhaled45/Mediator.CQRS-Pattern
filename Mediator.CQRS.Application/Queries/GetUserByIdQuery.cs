using Mediator.CQRS.Models;
using MediatR;

namespace Mediator.CQRS.Queries
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public int Id { get; set; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }

}
