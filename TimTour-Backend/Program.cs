using System.Net;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

class Program
{
    static void Main()
    {

        IHostBuilder hostBuilder = Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder
                    .UseStartup<Startup>()
                    .UseKestrel((hostingContext, options) =>
                    {
                        options.Listen(IPAddress.Any, 7001); // HTTP
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
