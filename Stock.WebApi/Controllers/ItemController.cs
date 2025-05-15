using Microsoft.AspNetCore.Mvc;
using Stock.Application.Items.Dtos;
using Stock.Application.Items.Interfaces;

namespace Stock.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController(IItemService itemService) : ControllerBase
{
    [HttpGet(Name = "GetItem")]
    public async Task<ActionResult<List<GetItemDto>>> Get()
    {
        var items = await itemService.GetItemsAsync();
        return Ok(items);
    }

    [HttpPut("{id:int}", Name = "UpdateItem")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateItemDto dto)
    {
        if (id != dto.Id)
            return BadRequest("ID mismatch between route and body.");

        var updated = await itemService.UpdateItemAsync(dto);
        if (updated == null)
            return NotFound();

        return Ok(updated);
    }

    [HttpDelete("{id:int}", Name = "DeleteItem")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await itemService.DeleteItemAsync(id);
        return success ? NoContent() : NotFound();
    }
}
