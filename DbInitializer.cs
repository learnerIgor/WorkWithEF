using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDRental
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;
        readonly DateTime Date = new DateTime(2022, 1, 6);

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            Person mark = new Person { Id = 1, Name = "Mark", Surname = "Simpson", Phone = 12345 };
            Person sam = new Person { Id = 2, Name = "Sam", Surname = "Adamson", Phone = 1357 };
            modelBuilder.Entity<Person>().HasData(mark, sam);

            Language russia = new Language { Id = 1, NameLanguage = "Russia", LastUpdate = DateTime.Now };
            modelBuilder.Entity<Language>().HasData(russia);

            Actor oscar = new Actor { Id = 3, Name = "Oscar", Surname = "Wilson", Phone = 5646757, Popularity = true };
            modelBuilder.Entity<Actor>().HasData(oscar);

            Category crime = new Category { Id = 1, CategoryName = "Crime", LastUpdate = Date.AddYears(-28) };
            modelBuilder.Entity<Category>().HasData(crime);

            Supplier samuel = new Supplier { Id = 4, Name = "Samuel", Surname = "Aldridge", Phone = 12342435, LastDelivery = Date, LegalForm = "LLC", BankDetails = "12345BY5345DF", Reliability = true };
            Supplier tom = new Supplier { Id = 5, Name = "Tom", Surname = "Robertson", Phone = 12342, LastDelivery = Date, LegalForm = "IE", BankDetails = "BY345BY5345DF", Reliability = true };
            modelBuilder.Entity<Supplier>().HasData(samuel, tom);

            modelBuilder.Entity<Actor>()
                    .HasMany(e => e.Film)
                    .WithMany(e => e.Actor)
                    .UsingEntity<ActorFilm>(
                        "ActorFilm",
                        l => l.HasOne<Film>().WithMany(e => e.ActorFilm).HasForeignKey(e => e.FilmId),
                        r => r.HasOne<Actor>().WithMany(e => e.ActorFilm).HasForeignKey(e => e.ActorId),
                        j =>
                        {
                            j.HasKey("ActorId", "FilmId");
                            j.HasData(new { ActorId = 3, FilmId = 1 });
                        });

            Film pulpFiction = new Film { Id = 1, Title = "Pulp Fiction", Description = "The plot is composed of several stories", ReleaseYear = Date.AddYears(-28), RentalDuration = 5, RentalRate = 10, Length = 154, ReplacementCost = 50, Rating = 10, FullText = "The plot is composed of several stories", LanguageId = russia.Id, SupplierId = samuel.Id };
            Film snatch = new Film { Id = 2, Title = "Snatch", Description = "Characters dream of hitting the 'big jackpot'", ReleaseYear = Date.AddYears(-23), RentalDuration = 3, RentalRate = 10, Length = 102, ReplacementCost = 60, Rating = 10, FullText = "Characters dream of hitting the 'big jackpot'", LanguageId = russia.Id, SupplierId = tom.Id };
            Film twoSmokingBarrels = new Film { Id = 3, Title = "Lock, Stock and Two Smoking Barrels", Description = "The film is set in London.", ReleaseYear = Date.AddYears(-25), RentalDuration = 2, RentalRate = 10, Length = 107, ReplacementCost = 100, Rating = 10, FullText = "Lock, Stock and Two Smoking Barrels", LanguageId = russia.Id, SupplierId = tom.Id };
            modelBuilder.Entity<Film>().HasData(pulpFiction, snatch, twoSmokingBarrels);

            Country englang = new() { Id = 1, NameCountry = "England" };
            Country belarus = new() { Id = 2, NameCountry = "Belarus" };
            modelBuilder.Entity<Country>().HasData(englang, belarus);

            City london = new() { Id = 1, NameCity = "London", CountryId = englang.Id };
            City minsk = new() { Id = 2, NameCity = "Minsk", CountryId = belarus.Id };
            modelBuilder.Entity<City>().HasData(minsk, london);

            Street theMall = new() { Id = 1, NameStreet = "The Mall", HouseNumber = 12, CityId = london.Id };
            Street maksimaB = new() { Id = 2, NameStreet = "Maxim Bogdanovich", HouseNumber = 13, CityId = minsk.Id };
            modelBuilder.Entity<Street>().HasData(maksimaB, theMall);
        }
    }
}
