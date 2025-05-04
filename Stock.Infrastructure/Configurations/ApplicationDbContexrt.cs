using Microsoft.EntityFrameworkCore;
using Stock.Domain.Departments.Entities;
using Stock.Domain.Items.Entities;

namespace Stock.Infrastructure.Configurations;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Item> Items { get; set; }
}






