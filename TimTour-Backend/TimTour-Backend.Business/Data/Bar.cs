﻿using System;
namespace TimTour_Backend.Business.Data
{
    public class Bar
    {
        public Bar(string name, string address, string phoneNumber, string? webSiteURL)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            WebSiteURL = webSiteURL;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? WebSiteURL { get; set; }
    }
}

