using ReservatioanWebApplication.Models;
using System.Numerics;

namespace ReservatioanWebApplication.Interfaces;

public interface IDoctorService
{
    int Add(Doctor doctor);
    List<Doctor> GetAll();
    int? GetById(int id);
    bool Update(Doctor doctor);
    bool Delete(int id);
}
