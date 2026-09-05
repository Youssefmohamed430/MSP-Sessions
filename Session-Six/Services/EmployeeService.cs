using Microsoft.EntityFrameworkCore;
using Session_Six.DTOs;
using Session_Six.IServices;

namespace Session_Six.Services;

public class EmployeeService(AppDbContext context) : IEmployeeService
{
    public List<EmployeeDto> GetAll()
    {
        var Employees = context.Employees
            .Include(e => e.Role)
            .Include(e => e.Department)
            .Select(e => new EmployeeDto
            {
                Id = e.Id,
                Name = e.Name,
                Position = e.Role.RoleName,
                DeptName = e.Department.DepName
            })
            .ToList();

        return Employees;

    }

    public EmployeeDto GetById(int id)
    {
        var employee = context.Employees
            .Include(e => e.Role)
            .Include(e => e.Department)
            .Where(e => e.Id == id)
            .Select(e => new EmployeeDto
            {
                Id = e.Id,
                Name = e.Name,
                Position = e.Role.RoleName,
                DeptName = e.Department.DepName
            })
            .FirstOrDefault();

        return employee;
    }
    public Result GetByIdV2(int id)
    {
        var employee = context.Employees
            .Include(e => e.Role)
            .Include(e => e.Department)
            .Where(e => e.Id == id)
            .Select(e => new EmployeeDto
            {
                Id = e.Id,
                Name = e.Name,
                Position = e.Role.RoleName,
                DeptName = e.Department.DepName
            })
            .FirstOrDefault();

        if (employee == null)
            return new Result { IsSuccess = false, Message = "Employee not found" };

        return new Result { IsSuccess = true, Message = "Employee found", Data = employee };
    }
    public string Add(CreateEmployeeDto employee)
    {
        try
        {
            var roleExists = context.Roles.Any(r => r.RoleId == employee.RoleId);
            var departmentExists = context.Departments.Any(d => d.Id == employee.DepartmentId);
            if (!roleExists)
                return "Role does not exist";
            if (!departmentExists)
                return "Department does not exist";

            var employeeEntity = new Employee
            {
                Name = employee.Name,
                RoleId = employee.RoleId,
                DeptId = employee.DepartmentId,
                Email = employee.Email
            };
            context.Employees.Add(employeeEntity);
            context.SaveChanges();
        }
        catch (Exception ex)
        {
            return $"Error adding employee: {ex.Message}";
        }
        return "Employee added successfully";
    }
    public Result AddV2(CreateEmployeeDto employee)
    {
        try
        {
            var roleExists = context.Roles.Any(r => r.RoleId == employee.RoleId);
            var departmentExists = context.Departments.Any(d => d.Id == employee.DepartmentId);
            if (!roleExists)
                return new Result { IsSuccess = false, Message = "Role does not exist" };
            if (!departmentExists)
                return new Result { IsSuccess = false, Message = "Department does not exist" };

            var employeeEntity = new Employee
            {
                Name = employee.Name,
                RoleId = employee.RoleId,
                DeptId = employee.DepartmentId
            };
            context.Employees.Add(employeeEntity);
            context.SaveChanges();
        }
        catch (Exception ex)
        {
            return new Result { IsSuccess = false, Message = $"Error adding employee: {ex.Message}" };
        }
        return new Result { IsSuccess = true, Message = "Employee added successfully" };
    }

    public Result Update(int empId, UpdateEmployeeDto employee)
    {
        try
        {
            var employeeEntity = context.Employees.FirstOrDefault(e => e.Id == empId);

            if (employeeEntity == null)
                return new Result { IsSuccess = false, Message = "Employee not found" };

            employeeEntity.Name = employee.Name;
            employeeEntity.RoleId = employee.RoleId;
            employeeEntity.DeptId = employee.DepartmentId;
            employeeEntity.Email = employee.Email;
            context.SaveChanges();
        }
        catch (Exception ex)
        {
            return new Result { IsSuccess = false, Message = $"Error updating employee: {ex.Message}" };
        }
        return new Result { IsSuccess = true, Message = "Employee updated successfully" };
    }
    public Result Delete(int EmpId)
    {
        var employeeEntity = context.Employees.FirstOrDefault(e => e.Id == EmpId);

        if (employeeEntity == null)
            return new Result { IsSuccess = false, Message = "Employee not found" };

        employeeEntity.IsDeleted = true;

        context.SaveChanges();

        return new Result { IsSuccess = false, Message = "Employee Deleted successfully!" };
    }
}
