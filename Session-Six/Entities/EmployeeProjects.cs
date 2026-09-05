namespace Session_Six.Entities;

public class EmployeeProjects
{
    public int EmpId { get; set; }
    public int ProjectId { get; set; }
    public Employee Employee { get; set; }
    public Project Project { get; set; }
}
