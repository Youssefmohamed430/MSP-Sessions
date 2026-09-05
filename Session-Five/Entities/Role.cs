namespace Session_Five.Entities;

public class Role
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    public Employee Employee { get; set; }
}
