namespace Session_Four;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public override string ToString()
    {
        return $"Name : {this.Name} | UserName : {this.Username} | Password : {this.Password} | Email : {this.Email} | Role : {this.Role}";
    }
}
