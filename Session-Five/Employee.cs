using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Session_Five;

//[Table(name:"Emps")]
public class Employee
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    public bool IsDeleted { get; set; }
    public int RoleId { get; set; }
    public int DeptId { get; set; }
    public Department Department { get; set; }
    public Role Role { get; set; }
    public List<EmployeeProjects> EmployeeProjects { get; set; }
}