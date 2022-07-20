using HotelListingApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApp.Configuration.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "New Demon Hotel",
                    Address = "Wasigton Dc",
                    CountyId = 1,
                    Rating = 2.1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Taj Hotel",
                    Address = "Delhi",
                    CountyId = 2,
                    Rating = 3.2
                }
                );
        }
    }
}
