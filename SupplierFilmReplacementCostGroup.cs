using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class SupplierFilmReplacementCostGroup
    {
        public string? SupplierName { get; set; }
        public int FilmCount { get; set; } // количество фильмов
        public int TotalReplacementCost { get; set; } // совокупная цена замены всех фильмов     
    }
}
