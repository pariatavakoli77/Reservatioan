using System;

namespace ReservatioanWebApplication.Models;

public class Payment
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public decimal Amount { get; set; }
    public decimal RefundAmount { get; set; }
    public Enum Status{ get; set; }
    public DateTime PaidAt { get; set; }
    public DateTime RefundedAt { get; set; }

}
