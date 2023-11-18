using System;
namespace TimTour_Backend.Business.Configuration
{
    public class Config
    {
        public string CertificatePath { get; set; } = "";
        public string CertificatePassword { get; set; } = "";
        public int HTTP_Port { get; set; } = 80;
        public int HTTPS_Port { get; set; } = 443;
    }
}

