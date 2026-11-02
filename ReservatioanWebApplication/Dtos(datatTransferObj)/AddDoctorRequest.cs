using ReservatioanWebApplication.Enums;

namespace ReservatioanWebApplication.Dtos_datatTransferObj_;

public class AddDoctorRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; }
    public string MedicalCode { get; set; }

    public DoctorSpecialty Specialty { get; set; }
    public DoctorLicense LastLicense { get; set; }

    public List<DayOfWeek> WorkDays { get; set; }
    public TimeOnly StartWorkTime { get; set; }
    public TimeOnly EndWorkTime { get; set; }
    public DoctorSlotDurationMinutes SlotDuration { get; set; }

    public decimal ConsultationFee { get; set; }

    public AddressRequest Address { get; set; }
}