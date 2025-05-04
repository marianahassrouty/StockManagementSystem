using Stock.Application.Departments.Dtos;
using Stock.Application.Departments.Interfaces;
using Stock.Domain.Departments.Entities;
using Stock.Domain.Departments.Repository;

namespace Stock.Application.Departments.Services;

public class DepartmentService(IDepartmentRepository departmentRepository) : IDepartmentService
{
    public async Task<GetDepartmentDto?> GetDepartmentByIdAsync(int id)
    {
        var dep = await departmentRepository.GetDepartmentByIdAsync(id);

        var depDto = new GetDepartmentDto(dep);
        return depDto;
    }

    public async Task<List<GetDepartmentDto>> GetDepartmentsAsync()
    {
        var departments = await departmentRepository.GetDepartmentsAsync();
        var departmentDtos = departments.Select(dep => new GetDepartmentDto(dep)).ToList();
        return departmentDtos;
    }
}
