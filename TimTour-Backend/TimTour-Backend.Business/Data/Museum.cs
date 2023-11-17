using System;
namespace TimTour_Backend.Business.Data
{
    public class Museum
    {
        public Museum(string name, string address, string webSiteURL)
        {
            Name = name;
            Address = address;
            WebSiteURL = webSiteURL;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string? WebSiteURL { get; set; }
    }
}

