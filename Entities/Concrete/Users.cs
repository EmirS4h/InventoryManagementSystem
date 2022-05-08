using Core.Entities;

namespace Entities.Concrete
{
    public class Users : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RegisteredAt { get; set; }
        public string? LastLogin { get; set; }
        public string? Role { get; set; }
    }
}
