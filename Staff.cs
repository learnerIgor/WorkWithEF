using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Staff : Person
    {
        public bool Active { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }

        public int StoreId { get; set; }
        public Store? Store { get; set; }

        public List<Payment> Payments { get; set; } = new();

        public List<Rental> Rental { get; set; } = new();

        public Address? Address { get; set; }
    }
}
