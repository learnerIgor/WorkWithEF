using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Street
    {
        public int Id { get; set; }
        public string? NameStreet { get; set; }
        public int HouseNumber { get; set; }

        public int CityId { get; set; }
        public City? City { get; set; }
    }
}
