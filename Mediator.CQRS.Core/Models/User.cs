namespace Mediator.CQRS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(int Id , string Name , string Email)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
        }
    }
}
