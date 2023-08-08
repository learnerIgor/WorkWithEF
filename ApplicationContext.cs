using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DVDRental
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Staff> Staffs { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<Street> Streets { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Address> Address { get; set; } = null!;
        public DbSet<Store> Stores { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Film> Films { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;
        public DbSet<Actor> Actors { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Inventory> Inventories { get; set; } = null!;
        public DbSet<Rental> Rentals { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<ActorFilm> ActorFilms { get; set; } = null!;
        public DbSet<SupplierFilmReplacementCostGroup> SupplierFilmReplacementCostGroup { get; set; } = null!; //представление
        public ApplicationContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().UseTpcMappingStrategy();

            new DbInitializer(modelBuilder).Seed();

            modelBuilder.Entity<SupplierFilmReplacementCostGroup>(pc =>
            {
                pc.HasNoKey();
                pc.ToView("View_FilmsBySupplier");
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }
}
