using System.Security.Principal;

namespace ReservatioanWebApplication.Models;

public class Doctor
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; }
    public string MedicalCode { get; set; }
    public enum Especialty
    {

    }
    public enum LastLicense
    {

    }
    public Enum WorkDays { get; set; }
    public Enum SlotDuration { get; set; }
    public decimal ConsultationFee { get; set; }
    public int AddressId { get; set; }
    
}
