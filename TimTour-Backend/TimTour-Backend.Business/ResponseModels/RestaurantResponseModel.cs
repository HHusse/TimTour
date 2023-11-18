using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;

namespace TimTour_Backend.Business.ResponseModels
{
    public class RestaurantResponseModel
    {
        public RestaurantResponseModel(string name, RestaurantType type, string address, string phoneNumber, string? webSiteURL)
        {
            Name = name;
            Type = RestaurantTypeMapper.Mapper.First(t => t.Key == type).Value;
            Address = address;
            PhoneNumber = phoneNumber;
            WebSiteURL = webSiteURL;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? WebSiteURL { get; set; }
    }
}

