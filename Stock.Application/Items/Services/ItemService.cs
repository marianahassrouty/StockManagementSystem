using Stock.Application.Items.Dtos;
using Stock.Application.Items.Interfaces;
using Stock.Domain.Items.Repository;

namespace Stock.Application.Items.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<List<GetItemDto>> GetItemsAsync()
        {
            var items = await _itemRepository.GetItemsAsync();
            var itemDtos = items.Select(item => new GetItemDto(item)).ToList();
            return itemDtos;
        }

        public async Task<GetItemDto?> GetItemByIdAsync(int id)
        {
            var item = await _itemRepository.GetItemByIdAsync(id);
            if (item == null)
                return null;

            return new GetItemDto(item);
        }

        public async Task<GetItemDto?> UpdateItemAsync(UpdateItemDto dto)
        {
            var item = await _itemRepository.GetItemByIdAsync(dto.Id);
            if (item == null)
                return null;

            item.Name = dto.Name;
            item.Description = dto.Description;
            item.Price = dto.Price;
            item.DepartmentId = dto.DepartmentId;

            await _itemRepository.UpdateItemAsync(item);
            return new GetItemDto(item);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var item = await _itemRepository.GetItemByIdAsync(id);
            if (item == null)
                return false;

            await _itemRepository.DeleteItemAsync(item);
            return true;
        }
    }
}
