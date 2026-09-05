using Session_Five.DTOs;

namespace Session_Five.IServices;

public interface IEmployeeService
{
    List<EmployeeDto> GetAll();
    EmployeeDto GetById(int id);
    Result GetByIdV2(int id);
    string Add(CreateEmployeeDto employee);
    Result AddV2(CreateEmployeeDto employee);
    Result Delete(int EmpId);
    Result Update(int empId,UpdateEmployeeDto employee);
}
