using System.ComponentModel.DataAnnotations;

namespace Session_Six.DTOs;

public class CreateEmployeeDto
{
    [MaxLength(100)]
    [Required]
    public string Name { get; set; }
    [Required]
    public int RoleId { get; set; }
    [Required]
    public int DepartmentId { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
