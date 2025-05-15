using Stock.Application.Departments.Dtos;

namespace Stock.Application.Departments.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<GetDepartmentDto>> GetDepartmentsAsync();
        Task<GetDepartmentDto?> GetDepartmentByIdAsync(int id);
        Task<bool> DeleteDepartmentAsync(int id);
        Task<GetDepartmentDto?> UpdateDepartmentAsync(UpdateDepartmentDto dto);
    }
}
