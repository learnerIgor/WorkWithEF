using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Customer : Person
    {
        public string? Email { get; set; }
        public bool Active { get; set; }

        public int AddressId { get; set; }
        public Address? Address { get; set; }

        public Rental? Rental { get; set; }
        
        public List<Payment> Payment { get; set; } = new();
    }
}
