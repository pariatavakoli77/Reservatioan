using ReservatioanWebApplication.Models;
using System.Runtime.InteropServices;

namespace ReservatioanWebApplication.Contracts;

public interface ICustomService<T>
{
    int Add(T item);
    List<T> GetAll();
    T? GetById(int id);
    bool Update(T item);
    bool Delete(int id);
}
