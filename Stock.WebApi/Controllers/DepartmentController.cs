using Microsoft.AspNetCore.Mvc;
using Stock.Application.Departments.Dtos;
using Stock.Application.Departments.Interfaces;

namespace Stock.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController(IDepartmentService departmentService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<GetDepartmentDto>>> Get()
    {
        var departments = await departmentService.GetDepartmentsAsync();
        return Ok(departments);
    }


    [HttpDelete("{id:int}", Name = "DeleteDepartment")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await departmentService.DeleteDepartmentAsync(id);
        if (!success)
            return NotFound();

        return NoContent();
    }

    [HttpPut("{id:int}", Name = "UpdateDepartment")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateDepartmentDto dto)
    {
        if (id != dto.Id)
            return BadRequest("ID mismatch between route and body.");

        var updated = await departmentService.UpdateDepartmentAsync(dto);
        if (updated == null)
            return NotFound();

        return Ok(updated);
    }
}
