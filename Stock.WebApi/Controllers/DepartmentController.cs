using Microsoft.AspNetCore.Mvc;
using Stock.Application.Departments.Dtos;
using Stock.Application.Departments.Interfaces;
using Stock.Domain.Departments.Entities;

namespace Stock.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController(IDepartmentService departmentService) : ControllerBase
{
    [HttpGet(Name = "GetDepartment")]
    public async Task<ActionResult<List<GetDepartmentDto>>> Get()
    {
        var departments = await departmentService.GetDepartmentsAsync();
        return Ok(departments);
    }
}
