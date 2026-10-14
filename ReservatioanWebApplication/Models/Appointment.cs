using System;
using System.Reflection.Metadata;

namespace ReservatioanWebApplication.Models;

public class Appointment
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public DateTime Date { get; set; }
    public Enum Status { get; set; }
    public string PatientDescription { get; set; }
    public DateTime ReservedAt { get; set; }
    
//    RowVersion -> برا? کنترل Concurrency 
}
