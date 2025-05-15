using Stock.Domain.Items.Entities;

namespace Stock.Application.Items.Dtos
{
    public record GetItemDto(int Id, string Name, string Description)
    {
        public GetItemDto(Item item) : this(item.Id, item.Name, item.Description)
        {
        }
    }
}
