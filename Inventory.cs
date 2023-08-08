using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Inventory
    {
        public int Id { get; set; }
        
        public int FilmId { get; set; }
        public Film? Film { get; set; }

        public int RentalId { get; set; }
        public Rental? Rental { get; set; }
    }
}
