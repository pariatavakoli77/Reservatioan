using ReservatioanWebApplication.MyDomain.Enums;
namespace ReservatioanWebApplication.MyDomain.Entities;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public string? Email { get; set; }
    public UserRole Role { get; set; }
    public Doctor? Doctor { get; set; }
    public Patient? Patient { get; set; }
}

