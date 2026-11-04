namespace ReservatioanWebApplication.MyDomain.Entities;

public class AppointmentFile
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }
 }
