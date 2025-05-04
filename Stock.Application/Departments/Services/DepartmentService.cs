using Stock.Application.Departments.Interfaces;
using Stock.Domain.Departments.Entities;
using Stock.Domain.Departments.Repository;

namespace Stock.Application.Departments.Services;

public class DepartmentService(IDepartmentRepository departmentRepository) : IDepartmentService
{
    public async Task<Department?> GetDepartmentByIdAsync(int id)
    {
        return await departmentRepository.GetDepartmentByIdAsync(id);
    }

    public async Task<List<Department>> GetDepartmentsAsync()
    {
        return [.. await departmentRepository.GetDepartmentsAsync()];
    }
}
