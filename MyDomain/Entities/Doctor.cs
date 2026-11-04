
using ReservatioanWebApplication.MyDomain.Enums;

namespace ReservatioanWebApplication.MyDomain.Entities;

public class Doctor
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; }
    public string MedicalCode { get; set; }
    public DoctorSpecialty Specialty { get; set; }
    public DoctorLicense LastLicense { get; set; }
    public List<DayOfWeek> WorkDays { get; set; } = new();
    public DoctorSlotDurationMinutes SlotDuration { get; set; }
    public decimal ConsultationFee { get; set; }
    public int AddressId { get; set; }
    public Address Address { get; set; }
    public TimeOnly StartWorkTime { get; set; }
    public TimeOnly EndWorkTime { get; set; }
}
