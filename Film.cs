using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class Film
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int RentalDuration { get; set; }
        public float RentalRate { get; set; }
        public int Length { get; set; }
        public int ReplacementCost { get; set; }
        public int Rating { get; set; }
        public string? FullText { get; set; }

        public int LanguageId { get; set; }
        public Language? Language { get; set; }

        public List<Actor> Actor { get; set; } = new();

        public List<Category> Category { get; set; } = new();

        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        public List<Inventory> Inventory { get; set; } = new();

        public List<ActorFilm> ActorFilm { get; set; } = new();
    }
}
