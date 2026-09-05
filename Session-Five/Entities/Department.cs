namespace Session_Five.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string DepName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}