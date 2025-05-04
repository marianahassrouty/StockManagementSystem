using Stock.Application.Departments.Dtos;
using Stock.Domain.Departments.Entities;

namespace Stock.Application.Departments.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<GetDepartmentDto>> GetDepartmentsAsync();
        Task<GetDepartmentDto?> GetDepartmentByIdAsync(int id);
    }
}
