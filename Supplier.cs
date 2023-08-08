using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Supplier : Person
    {
        public DateTime LastDelivery { get; set; }
        public string? LegalForm { get; set; }
        public string? BankDetails { get; set; }
        public bool Reliability { get; set; }

        public List<Film> Films { get; set; } = new();
    }
}
