using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using ReservatioanWebApplication.MyApplication.Interfaces;
using ReservatioanWebApplication.MyInfrastructure.Persistence.Contexts;
using ReservatioanWebApplication.MyInfrastructure.Services;

namespace MyInfrastructure;

public static class ConfigureLayer
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        string connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IDoctorService, DoctorService>();

        // Register Health Checks services
        services.AddHealthChecks()
            // 1. Built-in EF Core database check
            .AddDbContextCheck<AppDbContext>("database", failureStatus: HealthStatus.Unhealthy)
                //.AddCheck<SampleHealthCheck>("sample"); 
            .AddCheck("Sample", () => HealthCheckResult.Healthy("A healthy result."));


        return services;
    }
}