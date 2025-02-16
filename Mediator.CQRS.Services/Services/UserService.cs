using Mediator.CQRS.Interfaces;
using Mediator.CQRS.Models;

namespace Mediator.CQRS.Services
{
    public class UserService : IUserService
    {
        private static List<User> _users = new List<User>();
            
          
        public User AddUser(User user)
        {
            _users.Add(user);
            return user;
        }

        public User GetUserById(int id)
        {
           return _users[id];
        }

        public List<User> GetUsers()
        {
            return _users;
        }
    }
}
