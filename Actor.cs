using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Actor : Person
    {
        public bool Popularity { get; set; }
        public List<Film> Film { get; set; } = new();
        public List<ActorFilm> ActorFilm { get; set; } = new();
    }
}
