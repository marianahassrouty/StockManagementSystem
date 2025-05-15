using Microsoft.EntityFrameworkCore;
using Stock.Domain.Items.Entities;
using Stock.Domain.Items.Repository;
using Stock.Infrastructure.Configurations;

namespace Stock.Infrastructure.Items.Repositories;

public class ItemRepository(ApplicationDbContext context) : IItemRepository
{
    public async Task<Item?> GetItemByIdAsync(int id)
    {
        return await context.Items.FirstOrDefaultAsync(item => item.Id == id);
    }

    public async Task<IEnumerable<Item>> GetItemsAsync()
    {
        return await context.Items.ToListAsync();
    }

    public async Task<IEnumerable<Item>> GetItemsByDepartmentIdAsync(int departmentId)
    {
        return await context.Items
            .Where(item => item.DepartmentId == departmentId)
            .ToListAsync();
    }

    public async Task UpdateItemAsync(Item item)
    {
        context.Items.Update(item);
        await context.SaveChangesAsync();
    }

    public async Task DeleteItemAsync(Item item)
    {
        context.Items.Remove(item);
        await context.SaveChangesAsync();
    }

    Task<List<Item>> IItemRepository.GetItemsAsync()
    {
        throw new NotImplementedException();
    }
}
