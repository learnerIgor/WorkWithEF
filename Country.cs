using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Country
    {
        public int Id { get; set; }
        public string? NameCountry { get; set; }

        public List<City> City { get; set; } = new();
        public List<Address> Address { get; set; } = new();
    }
}
