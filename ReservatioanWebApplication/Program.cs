using Asp.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using ReservatioanWebApplication.Data;
using ReservatioanWebApplication.MyApplication.Interfaces;
using ReservatioanWebApplication.MyInfrastructure.Services;
using MyInfrastructure;
using MyApplication ;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
            throw new InvalidOperationException("Connection string not found");
builder.Services
    .AddApplication()
    .AddInfrastructure(connectionString);


//builder.Services.AddCors();
builder.Services.AddCorsPolicy();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1);
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader("X-Api-Version"));
})
.AddMvc() // This is needed for controllers
.AddApiExplorer(options =>
{
    options.GroupNameFormat = "'v'V";
    options.SubstituteApiVersionInUrl = true;
});

// Register Health Checks services
builder.Services.AddHealthChecks()
    // 1. Built-in EF Core database check
    .AddDbContextCheck<AppDbContext>("database", failureStatus: HealthStatus.Unhealthy)
        //.AddCheck<SampleHealthCheck>("sample"); 
        .AddCheck("Sample", () => HealthCheckResult.Healthy("A healthy result."));


builder.Services.AddScoped<IDoctorService, DoctorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapHealthChecks("/healthz");

app.UseHttpsRedirection();

app.UseCors(PresentationLayerExtentions.MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();
