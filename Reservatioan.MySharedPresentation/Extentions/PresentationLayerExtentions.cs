using Microsoft.Extensions.DependencyInjection;
using Asp.Versioning;

namespace Reservatioan.MySharedPresentation.PresentationLayerExtentions;

public static class PresentationLayerExtentions
{
    public const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

    public static IServiceCollection AddCorsPolicy(this IServiceCollection services, string name)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(name: name, policy =>
            {
                policy 
                    .AllowAnyHeader()
                    .AllowAnyOrigin()
                    .AllowAnyMethod();
            });
        });
        return services;
    }

         public static IServiceCollection AddVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
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

        return services;
    }
}