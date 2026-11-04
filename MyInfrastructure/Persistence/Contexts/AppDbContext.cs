
using Microsoft.EntityFrameworkCore;
using ReservatioanWebApplication.MyDomain.Entities;

namespace ReservatioanWebApplication.MyInfrastructure.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Doctor> Doctors { get; set; }

}
