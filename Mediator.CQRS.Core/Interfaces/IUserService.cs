using Mediator.CQRS.Models;

namespace Mediator.CQRS.Interfaces
{
    public interface IUserService
    {
        public User AddUser(User user);
        public List<User> GetUsers();
        public User GetUserById(int id);
    }
}
