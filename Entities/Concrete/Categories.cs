using Core.Entities;

namespace Entities.Concrete
{
    public class Categories : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
