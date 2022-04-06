﻿using AutoMapper;
using HotelListingApp.Data;
using HotelListingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApp.Configuration
{
    public class MapperInitializer:Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap(); 
            CreateMap<Country, CreateCountryDTO>().ReverseMap(); 
            CreateMap<Hotel, HotelDTO>().ReverseMap(); 
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap(); 
        }
    }
}
