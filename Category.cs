using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public DateTime LastUpdate { get; set; }

        public List<Film> Film { get; set; } = new();
    }
}
