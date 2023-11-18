
namespace TimTour_Backend.Business.Data
{
    public class Restaurant
    {
        public Restaurant(string name, RestaurantType type, string address, string phoneNumber, string webSiteURL)
        {
            Name = name;
            Type = type;
            Address = address;
            PhoneNumber = phoneNumber;
            WebSiteURL = webSiteURL;
        }

        public string Name { get; set; }
        public RestaurantType Type { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? WebSiteURL { get; set; }

    }
}

