using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Rental? Rental { get; set; }

        public int StaffId { get; set; }
        public Staff? Staff { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } = new();
    }
}
