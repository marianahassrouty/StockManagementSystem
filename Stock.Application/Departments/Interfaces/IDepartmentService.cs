using Stock.Domain.Departments.Entities;

namespace Stock.Application.Departments.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartmentsAsync();
        Task<Department?> GetDepartmentByIdAsync(int id);
    }
}
