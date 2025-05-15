using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Items.Dtos
{
    public record UpdateItemDto(int Id, string Name, string Description)
    {
        public decimal Price { get; internal set; }
        public int DepartmentId { get; internal set; }
    }
}
