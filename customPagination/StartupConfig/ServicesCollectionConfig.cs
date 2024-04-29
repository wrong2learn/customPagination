using customPagination.DataContext;
using customPagination.Repositories;
using Microsoft.EntityFrameworkCore;

namespace customPagination.StartupConfig;

public static class ServicesCollectionConfig
{
    public static IServiceCollection RegisterServices(this IServiceCollection services
        , ConfigurationManager configuration)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddDbContext<PersonDbContext>(options =>
        {
            var connStr = configuration.GetConnectionString("personDbConString");
            options.UseSqlServer(connStr);
        });
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });

        return services;
    }
}