using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class ActorFilm
    {
        [Key]
        public int ActorId { get; set; }
        public int FilmId { get; set; }
    }
}
