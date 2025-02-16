using Mediator.CQRS.Commands;
using Mediator.CQRS.Handlers;
using Mediator.CQRS.Interfaces;
using Mediator.CQRS.Models;
using Mediator.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator mediator = mediator;

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var query = new GetUsersQuery();
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var query = new GetUserByIdQuery(id);
            var result = await mediator.Send(query);
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<User>> AddNewUser(User user)
        {
            var command = new AddUserCommand(user.Id,user.Name,user.Email);
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
