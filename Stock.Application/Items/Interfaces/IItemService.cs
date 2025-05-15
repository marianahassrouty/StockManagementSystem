using Stock.Application.Items.Dtos;

namespace Stock.Application.Items.Interfaces
{
    public interface IItemService
    {
        Task<List<GetItemDto>> GetItemsAsync();
        Task<GetItemDto?> GetItemByIdAsync(int id);
        Task<GetItemDto?> UpdateItemAsync(UpdateItemDto dto);
        Task<bool> DeleteItemAsync(int id);
    }
}
