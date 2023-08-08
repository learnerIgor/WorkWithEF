using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Store
    {
        public int Id { get; set; }
        public string? NameStore { get; set; }

        public int AddressId { get; set; }
        public Address? Address { get; set; }

        public Staff? Staff { get; set; }
    }
}
