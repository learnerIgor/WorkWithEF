using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Address
    {
        public int Id { get; set; }
        public int PostCode { get; set; }
        public int Phone { get; set; }

        //public int CityId { get; set; }
        //public City? City { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }

        public Customer? Customer { get; set; }

        public Store? Store { get; set; }

        public int? StaffId { get; set; }
        public Staff? Staff { get; set; }

    }
}
