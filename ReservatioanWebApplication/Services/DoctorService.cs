using ReservatioanWebApplication.Data;
using ReservatioanWebApplication.Interfaces;
using ReservatioanWebApplication.Models;

namespace ReservatioanWebApplication.Services;

public class DoctorService : IDoctorService
{
    private readonly AppDbContext _dbContext;
      public int Add(Doctor doctor)
    {
        _dbContext.Set<Doctor>();
        Add(doctor);
        _dbContext.SaveChanges();
        return doctor.Id;
    }  
}
