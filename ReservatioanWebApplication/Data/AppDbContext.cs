using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ReservatioanWebApplication.Models;

namespace ReservatioanWebApplication.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Doctor> Doctors { get; set; }

}
