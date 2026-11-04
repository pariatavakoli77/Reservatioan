using ReservatioanWebApplication.MyApplication.Contracts;
using ReservatioanWebApplication.MyDomain.Entities;

namespace ReservatioanWebApplication.MyApplication.Interfaces;

public interface IDoctorService : ICustomService<Doctor>
{
    int Add(Doctor doctor);
    List<Doctor> GetAll();
    Doctor? GetById(int id);
    bool Update(Doctor doctor);
    bool Delete(int id);
}
