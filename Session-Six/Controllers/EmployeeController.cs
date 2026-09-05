using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_Five.DTOs;
using Session_Five.IServices;

namespace Session_Six.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController(IEmployeeService employeeService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetEmployees()
    {
        var result = employeeService.GetAll();

        return Ok(result);
    }
    [HttpGet("{id}")]
    public IActionResult GetEmployeeById(int id)
    {
        var result = employeeService.GetById(id);

        if (result == null)
            return NotFound($"Employee with Id {id} not found");

        return Ok(result);
    }

    [HttpPost]
    public IActionResult AddEmployee([FromBody] CreateEmployeeDto employee)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = employeeService.Add(employee);
        if (result == "Role does not exist" || result == "Department does not exist")
            return BadRequest(result);
        return Created();
        //return Ok(result);
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
