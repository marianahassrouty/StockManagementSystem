using Stock.Domain.Items.Entities;

namespace Stock.Domain.Departments.Entities
{
    public class Department
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public ICollection<Item> Items { get; set; }

    }
}
