using Stock.Domain.Items.Entities;

namespace Stock.Domain.Items.Repository
{
    public interface IItemRepository
    {
        Task<List<Item>> GetItemsAsync();
        Task<Item?> GetItemByIdAsync(int id);           
        Task UpdateItemAsync(Item item);                
        Task DeleteItemAsync(Item item);                
    }
}
