using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApp.Data
{
    public class Country
    {
        
        public int Id { get; set; }

        public string Name { get; set; }
        public string SortName { get; set; }

        public virtual List<Hotel> Hotels { get; set; }
    }
}
