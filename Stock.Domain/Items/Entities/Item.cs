using Stock.Domain.Departments.Entities;

namespace Stock.Domain.Items.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string Image { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
