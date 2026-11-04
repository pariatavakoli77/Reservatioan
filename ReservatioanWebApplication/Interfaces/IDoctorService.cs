using ReservatioanWebApplication.Contracts;
using ReservatioanWebApplication.Models;

namespace ReservatioanWebApplication.Interfaces;

public interface IDoctorService : ICustomService<Doctor>
{
    int Add(Doctor doctor);
    List<Doctor> GetAll();
    Doctor? GetById(int id);
    bool Update(Doctor doctor);
    bool Delete(int id);
}
