using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Six.Entities;

public class Project
{
    public int Id { get; set; }
    public string ProjectCode { get; set; }
    public string ProjectName { get; set; }
    public List<EmployeeProjects> EmployeeProjects { get; set; }
}
