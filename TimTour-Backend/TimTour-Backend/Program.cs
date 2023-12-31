﻿using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using TimTour_Backend.Business.Configuration;
using TimTour_Backend.Data;

class Program
{
    static void Main()
    {
        var configManager = new TimTour_Backend.Business.Configuration.ConfigurationManager();
        Config config = configManager.GetConfiguration();

        Console.WriteLine(Environment.GetEnvironmentVariable("SQLCONNECTIONSTRING"));
        var dbContextOptions = new DbContextOptionsBuilder<TimTourContext>()
                .UseSqlServer(Environment.GetEnvironmentVariable("SQLCONNECTIONSTRING"));

        using (var context = new TimTourContext(dbContextOptions.Options))
        {
            context.Database.Migrate();
        }

        IHostBuilder hostBuilder = Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder
                    .UseStartup<Startup>()
                    .UseKestrel((hostingContext, options) =>
                    {
                        options.Listen(IPAddress.Any, config.HTTP_Port);
                        //options.Listen(IPAddress.Any, config.HTTPS_Port, listenOptions =>
                        //{
                        //    // HTTPS
                        //    var certificatePath = config.CertificatePath;
                        //    var certificatePassword = config.CertificatePassword;
                        //    var certificate = new X509Certificate2(certificatePath, certificatePassword);

                        //    listenOptions.UseHttps(certificate);
                        //});
                    }); ;
            });

        hostBuilder.Build().Run();
    }
}
