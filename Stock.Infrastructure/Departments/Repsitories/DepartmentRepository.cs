using Microsoft.EntityFrameworkCore;
using Stock.Domain.Departments.Entities;
using Stock.Domain.Departments.Repository;
using Stock.Infrastructure.Configurations;

namespace Stock.Infrastructure.Departments.Repsitories;

public class DepartmentRepository(ApplicationDbContext context) : IDepartmentRepository
{
    public async Task<Department?> GetDepartmentByIdAsync(int id)
    {
        return await context.Departments.FirstOrDefaultAsync(dep => dep.Id == id);
    }

    public async Task<IEnumerable<Department>> GetDepartmentsAsync()
    {
        return await context.Departments.ToListAsync();
    }
}
