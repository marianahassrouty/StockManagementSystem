using Stock.Domain.Departments.Entities;

namespace Stock.Domain.Departments.Repository;

public interface IDepartmentRepository
{
    Task<IEnumerable<Department>> GetDepartmentsAsync();
    Task<Department?> GetDepartmentByIdAsync(int id);
    Task UpdateDepartment(Department department);
    Task DeleteDepartment(Department department);
}
