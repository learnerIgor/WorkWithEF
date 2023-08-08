using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class City
    {
        public int Id { get; set; }
        public string? NameCity { get; set; }

        public int CountryId { get; set; }
        public Country? Country { get; set; }

        //public List<Address> Address { get; set; } = new();

        public List<Street> Street { get; set; } = new();
    }
}
