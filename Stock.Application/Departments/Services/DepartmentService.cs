using Stock.Application.Departments.Dtos;
using Stock.Application.Departments.Interfaces;
using Stock.Domain.Departments.Entities;
using Stock.Domain.Departments.Repository;

namespace Stock.Application.Departments.Services;

public class DepartmentService(IDepartmentRepository departmentRepository) : IDepartmentService
{
    public async Task<List<GetDepartmentDto>> GetDepartmentsAsync()
    {
        var departments = await departmentRepository.GetDepartmentsAsync();
        return departments.Select(dep => new GetDepartmentDto(dep)).ToList();
    }

    public async Task<GetDepartmentDto?> GetDepartmentByIdAsync(int id)
    {
        var dep = await departmentRepository.GetDepartmentByIdAsync(id);
        return dep == null ? null : new GetDepartmentDto(dep);
    }

    public async Task<bool> DeleteDepartmentAsync(int id)
    {
        var department = await departmentRepository.GetDepartmentByIdAsync(id);
        if (department == null)
            return false;

        await departmentRepository.DeleteDepartment(department);
        return true;
    }

    public async Task<GetDepartmentDto?> UpdateDepartmentAsync(UpdateDepartmentDto dto)
    {
        var department = await departmentRepository.GetDepartmentByIdAsync(dto.Id);
        if (department == null)
            return null;

        department.Name = dto.Name;
        department.Description = dto.Description;

        await departmentRepository.UpdateDepartment(department);
        return new GetDepartmentDto(department);
    }
}
