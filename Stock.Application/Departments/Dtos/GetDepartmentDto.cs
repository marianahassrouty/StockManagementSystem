using Stock.Domain.Departments.Entities;

namespace Stock.Application.Departments.Dtos
{
    public record GetDepartmentDto(int Id, string Name, string Description)
    {
        public GetDepartmentDto(Department department): this(department.Id, department.Name, department.Description)
        {
            
        }
    }
}
