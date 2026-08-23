/*
    ------------------>> Relations and Navigation Proberties <<-------------------
    1. One To One
    2. One To Many
    3. Many To Many
 */
using Microsoft.EntityFrameworkCore;
using Session_Five;

class Program
{
    static void Main(string[] args)
    {
        var context = new AppDbContext();
        //var Employee = new Employee()
        //{
        //    Name = "Emp1",
        //};
        //context.Employees.Add(Employee);
        //context.SaveChanges();
        //var role = new Role()
        //{
        //    RoleName = "User"
        //};
        //context.Roles.Add(role);
        //context.SaveChanges();
        //var Departments = new Department()
        //{
        //    DepName = "Dep1"
        //};
        //context.Departments.Add(Departments);
        //context.SaveChanges();
        //var Employee2 = new Employee()
        //{
        //    Name = "Emp2",
        //    RoleId = role.RoleId,
        //    DeptId = Departments.Id
        //};
        //context.Employees.Add(Employee2);
        //context.SaveChanges();

        var emp = context.Employees
            .AsNoTracking()
            .Include(e => e.Department)
            .Include(e => e.Role)
            .First(e => e.DeptId == 2);

        //emp.Name = "Emp22";
        //context.SaveChanges();

        Console.WriteLine(emp);
    }
}
