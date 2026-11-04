using Microsoft.EntityFrameworkCore;

using ReservatioanWebApplication.MyDomain.Entities;

namespace ReservatioanWebApplication.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Doctor> Doctors { get; set; }

}
