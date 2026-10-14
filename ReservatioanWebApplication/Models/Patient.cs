namespace ReservatioanWebApplication.Models;

public class Patient
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string NationalCode { get; set; }
    public string Phone { get; set; }
    public enum Gender
    {

    } 


 
}
