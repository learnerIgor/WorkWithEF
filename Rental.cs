using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public Inventory? Inventory { get; set; }

        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
    }
}
