using System;
namespace TimTour_Backend.Business.Data
{
    public class Hotel
    {
        public Hotel(string name, int stars, string address, string phoneNumber, string webSiteURL)
        {
            Name = name;
            Stars = stars;
            Address = address;
            PhoneNumber = phoneNumber;
            WebSiteURL = webSiteURL;
        }

        public string Name { get; set; }
        public int Stars { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? WebSiteURL { get; set; }
    }
}

