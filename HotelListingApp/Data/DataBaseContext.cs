using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApp.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "United State",
                    SortName = "US"
                },
                new Country
                {
                    Id = 2,
                    Name = "India",
                    SortName = "IN"
                });
            modelBuilder.Entity<Hotel>().HasData(
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
                });
        }

        public DbSet<Country> countries { get; set; }
        public DbSet<Hotel> hotels { get; set; }

    }
}
