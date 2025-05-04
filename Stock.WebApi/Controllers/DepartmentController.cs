using Microsoft.AspNetCore.Mvc;
using Stock.Application.Departments.Interfaces;
using Stock.Domain.Departments.Entities;

namespace Stock.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController(IDepartmentService departmentService) : ControllerBase
{
    [HttpGet(Name = "GetDepartment")]
    public async Task<ActionResult<IEnumerable<Department>>> Get()
    {
        var departments = await departmentService.GetDepartmentsAsync();
        return Ok(departments);
    }
}
