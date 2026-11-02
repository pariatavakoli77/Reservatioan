using ReservatioanWebApplication.Data;
using ReservatioanWebApplication.Interfaces;
using ReservatioanWebApplication.Models;

namespace ReservatioanWebApplication.Services;

public class DoctorService : IDoctorService
{
    private readonly AppDbContext _dbContext;
    public DoctorService(AppDbContext dbContext)
    {
        _dbContext = dbContext; 
    }
      public int Add(Doctor doctor)
    {
        
        _dbContext.Set<Doctor>().Add(doctor);
        _dbContext.SaveChanges();
        return doctor.Id;
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Doctor> GetAll()
    {
        throw new NotImplementedException();
    }

    public int GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Doctor doctor)
    {
        throw new NotImplementedException();
    }

    int? IDoctorService.GetById(int id)
    {
        return GetById(id);
    }
}
