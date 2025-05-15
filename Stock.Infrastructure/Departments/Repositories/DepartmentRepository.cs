using Microsoft.EntityFrameworkCore;
using Stock.Domain.Departments.Entities;
using Stock.Domain.Departments.Repository;
using Stock.Infrastructure.Configurations;

public class DepartmentRepository(ApplicationDbContext context) : IDepartmentRepository
{
    public async Task<IEnumerable<Department>> GetDepartmentsAsync()
    {
        return await context.Departments.ToListAsync();
    }

    public async Task<Department?> GetDepartmentByIdAsync(int id)
    {
        return await context.Departments.FindAsync(id);
    }

    public async Task UpdateDepartmentAsync(Department department)
    {
        context.Departments.Update(department);
        await context.SaveChangesAsync();
    }

    public async Task DeleteDepartmentAsync(Department department)
    {
        context.Departments.Remove(department);
        await context.SaveChangesAsync();
    }

    public Task UpdateDepartment(Department department)
    {
        throw new NotImplementedException();
    }

    public Task DeleteDepartment(Department department)
    {
        throw new NotImplementedException();
    }
}
