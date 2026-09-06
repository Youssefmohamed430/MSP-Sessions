using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_Six.DTOs;
using Session_Six.IServices;

namespace Session_Six.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController(IEmployeeService employeeService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetEmployees()
    {
        var result = employeeService.GetAll();

        return Ok(result); // 200 OK
    }

    [HttpGet("{id}")]
    public IActionResult GetEmployeeById(int id)
    {
        var result = employeeService.GetByIdV2(id);

        if (!result.IsSuccess)
            return NotFound(result); // 404 Not Found

        return Ok(result);
    }

    [HttpPost] // POST /api/Employee
    public IActionResult AddEmployee([FromBody] CreateEmployeeDto employee)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = employeeService.AddV2(employee);
        if (!result.IsSuccess)
            return BadRequest(result);
          
        return Created();// 201 Created
        //return Ok(result.Message);
    }

    [HttpPut("{empId}")]
    public IActionResult UpdateEmployee(int empId,[FromBody] UpdateEmployeeDto employee)
    {
        var result = employeeService.Update(empId, employee);

        if (!result.IsSuccess)
            return BadRequest(result.Message);
        return Ok(result.Message);
    }

    [HttpDelete]
    public IActionResult DeleteEmployee([FromQuery] int empId)
    {
        var result = employeeService.Delete(empId);
        if (!result.IsSuccess)
            return BadRequest(result.Message);
        return Ok(result.Message);
    }
}
