using System.ComponentModel.DataAnnotations;

namespace DVDRental
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Phone { get; set; }
    }
}
