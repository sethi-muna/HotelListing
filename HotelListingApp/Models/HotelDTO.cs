using HotelListingApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApp.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength:160,ErrorMessage ="Name is too long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Address is too long.")]
        public string Address { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountyId { get; set; }
    }
    
    public class HotelDTO:CreateHotelDTO
    {
        public int Id { get; set; }
        public Country Country { get; set; }
    }
}
