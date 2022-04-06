using HotelListingApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApp.Models
{    
    
    //for creating country.
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength:50,ErrorMessage ="Country name is too long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength:4,ErrorMessage ="Short name can't be too long.")]
        public string SortName { get; set; }
    }

    //middle layer between model object and api/service. for update or getting data.
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public List<Hotel> Hotels {get;set;}
    }
}
