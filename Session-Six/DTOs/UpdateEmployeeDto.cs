namespace Session_Six.DTOs;

public class UpdateEmployeeDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RoleId { get; set; }
    public int DepartmentId { get; set; }
    public string Email { get; set; }
}
