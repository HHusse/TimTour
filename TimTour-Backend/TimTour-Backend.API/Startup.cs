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
        string? connectionString = Environment.GetEnvironmentVariable("SQLCONNECTIONSTRING");
        services.AddDbContext<TimTourContext>(opt =>
        {
            opt.UseSqlServer(connectionString);
        });
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
