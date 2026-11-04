
using ReservatioanWebApplication.MyApplication.Contracts;
using ReservatioanWebApplication.MyApplication.Interfaces;
using ReservatioanWebApplication.MyDomain.Entities;
using ReservatioanWebApplication.MyInfrastructure.Persistence.Contexts;

namespace ReservatioanWebApplication.MyInfrastructure.Services;

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

    public int? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Doctor doctor)
    {
        throw new NotImplementedException();
    }

   
    Doctor? ICustomService<Doctor>.GetById(int id)
    {
        throw new NotImplementedException();
    }

    Doctor? IDoctorService.GetById(int id)
    {
        throw new NotImplementedException();
    }
}
