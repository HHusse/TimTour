using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimTour_Backend.Data;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("config.json")
        .Build();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        services.AddDbContext<TimTourContext>(opt =>
        {
            opt.UseSqlServer(Environment.GetEnvironmentVariable("SQLCONNECTIONSTRING"));
        });
        services.AddCors(options =>
        {
            options.AddPolicy("AllowOrigin",
                builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseCors("AllowOrigin");
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
