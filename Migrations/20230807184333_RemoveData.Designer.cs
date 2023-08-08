﻿// <auto-generated />
using System;
using DVDRental;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DVDRental.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230807184333_RemoveData")]
    partial class RemoveData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("PersonSequence");

            modelBuilder.Entity("ActorFilm", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("ActorFilm");

                    b.HasData(
                        new
                        {
                            ActorId = 3,
                            FilmId = 1
                        });
                });

            modelBuilder.Entity("CategoryFilm", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("CategoryFilm");
                });

            modelBuilder.Entity("DVDRental.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("StaffId")
                        .IsUnique()
                        .HasFilter("[StaffId] IS NOT NULL");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("DVDRental.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Crime",
                            LastUpdate = new DateTime(1994, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DVDRental.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("NameCity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DVDRental.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameCountry")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DVDRental.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseYear")
                        .HasColumnType("datetime2");

                    b.Property<int>("RentalDuration")
                        .HasColumnType("int");

                    b.Property<float>("RentalRate")
                        .HasColumnType("real");

                    b.Property<int>("ReplacementCost")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The plot is composed of several stories",
                            FullText = "The plot is composed of several stories",
                            LanguageId = 1,
                            Length = 154,
                            Rating = 10,
                            ReleaseYear = new DateTime(1994, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentalDuration = 5,
                            RentalRate = 10f,
                            ReplacementCost = 50,
                            SupplierId = 4,
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Characters dream of hitting the 'big jackpot'",
                            FullText = "Characters dream of hitting the 'big jackpot'",
                            LanguageId = 1,
                            Length = 102,
                            Rating = 10,
                            ReleaseYear = new DateTime(1999, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentalDuration = 3,
                            RentalRate = 10f,
                            ReplacementCost = 60,
                            SupplierId = 5,
                            Title = "Snatch"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The film is set in London.",
                            FullText = "Lock, Stock and Two Smoking Barrels",
                            LanguageId = 1,
                            Length = 107,
                            Rating = 10,
                            ReleaseYear = new DateTime(1997, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentalDuration = 2,
                            RentalRate = 10f,
                            ReplacementCost = 100,
                            SupplierId = 5,
                            Title = "Lock, Stock and Two Smoking Barrels"
                        });
                });

            modelBuilder.Entity("DVDRental.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("RentalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("RentalId")
                        .IsUnique();

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("DVDRental.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastUpdate = new DateTime(2023, 8, 7, 21, 43, 33, 113, DateTimeKind.Local).AddTicks(3872),
                            NameLanguage = "Russia"
                        });
                });

            modelBuilder.Entity("DVDRental.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RentalId")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RentalId");

                    b.HasIndex("StaffId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DVDRental.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [PersonSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.UseTpcMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mark",
                            Phone = 12345,
                            Surname = "Simpson"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sam",
                            Phone = 1357,
                            Surname = "Adamson"
                        });
                });

            modelBuilder.Entity("DVDRental.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.HasIndex("StaffId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("DVDRental.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("NameStore")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("DVDRental.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<string>("NameStreet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("DVDRental.Actor", b =>
                {
                    b.HasBaseType("DVDRental.Person");

                    b.Property<bool>("Popularity")
                        .HasColumnType("bit");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Oscar",
                            Phone = 5646757,
                            Surname = "Wilson",
                            Popularity = true
                        });
                });

            modelBuilder.Entity("DVDRental.Customer", b =>
                {
                    b.HasBaseType("DVDRental.Person");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("AddressId")
                        .IsUnique()
                        .HasFilter("[AddressId] IS NOT NULL");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DVDRental.Staff", b =>
                {
                    b.HasBaseType("DVDRental.Person");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("StoreId")
                        .IsUnique()
                        .HasFilter("[StoreId] IS NOT NULL");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("DVDRental.Supplier", b =>
                {
                    b.HasBaseType("DVDRental.Person");

                    b.Property<string>("BankDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastDelivery")
                        .HasColumnType("datetime2");

                    b.Property<string>("LegalForm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Reliability")
                        .HasColumnType("bit");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Name = "Samuel",
                            Phone = 12342435,
                            Surname = "Aldridge",
                            BankDetails = "12345BY5345DF",
                            LastDelivery = new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LegalForm = "LLC",
                            Reliability = true
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tom",
                            Phone = 12342,
                            Surname = "Robertson",
                            BankDetails = "BY345BY5345DF",
                            LastDelivery = new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LegalForm = "IE",
                            Reliability = true
                        });
                });

            modelBuilder.Entity("ActorFilm", b =>
                {
                    b.HasOne("DVDRental.Actor", null)
                        .WithMany("ActorFilm")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVDRental.Film", null)
                        .WithMany("ActorFilm")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryFilm", b =>
                {
                    b.HasOne("DVDRental.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVDRental.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DVDRental.Address", b =>
                {
                    b.HasOne("DVDRental.Country", "Country")
                        .WithMany("Address")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVDRental.Staff", "Staff")
                        .WithOne("Address")
                        .HasForeignKey("DVDRental.Address", "StaffId");

                    b.Navigation("Country");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("DVDRental.City", b =>
                {
                    b.HasOne("DVDRental.Country", "Country")
                        .WithMany("City")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DVDRental.Film", b =>
                {
                    b.HasOne("DVDRental.Language", "Language")
                        .WithMany("Film")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVDRental.Supplier", "Supplier")
                        .WithMany("Films")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("DVDRental.Inventory", b =>
                {
                    b.HasOne("DVDRental.Film", "Film")
                        .WithMany("Inventory")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVDRental.Rental", "Rental")
                        .WithOne("Inventory")
                        .HasForeignKey("DVDRental.Inventory", "RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("DVDRental.Payment", b =>
                {
                    b.HasOne("DVDRental.Customer", "Customer")
                        .WithMany("Payment")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVDRental.Rental", "Rental")
                        .WithMany()
                        .HasForeignKey("RentalId");

                    b.HasOne("DVDRental.Staff", "Staff")
                        .WithMany("Payments")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Rental");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("DVDRental.Rental", b =>
                {
                    b.HasOne("DVDRental.Customer", "Customer")
                        .WithOne("Rental")
                        .HasForeignKey("DVDRental.Rental", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVDRental.Staff", "Staff")
                        .WithMany("Rental")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("DVDRental.Store", b =>
                {
                    b.HasOne("DVDRental.Address", "Address")
                        .WithOne("Store")
                        .HasForeignKey("DVDRental.Store", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DVDRental.Street", b =>
                {
                    b.HasOne("DVDRental.City", "City")
                        .WithMany("Street")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DVDRental.Customer", b =>
                {
                    b.HasOne("DVDRental.Address", "Address")
                        .WithOne("Customer")
                        .HasForeignKey("DVDRental.Customer", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DVDRental.Staff", b =>
                {
                    b.HasOne("DVDRental.Store", "Store")
                        .WithOne("Staff")
                        .HasForeignKey("DVDRental.Staff", "StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("DVDRental.Address", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("DVDRental.City", b =>
                {
                    b.Navigation("Street");
                });

            modelBuilder.Entity("DVDRental.Country", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("City");
                });

            modelBuilder.Entity("DVDRental.Film", b =>
                {
                    b.Navigation("ActorFilm");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("DVDRental.Language", b =>
                {
                    b.Navigation("Film");
                });

            modelBuilder.Entity("DVDRental.Rental", b =>
                {
                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("DVDRental.Store", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("DVDRental.Actor", b =>
                {
                    b.Navigation("ActorFilm");
                });

            modelBuilder.Entity("DVDRental.Customer", b =>
                {
                    b.Navigation("Payment");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("DVDRental.Staff", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Payments");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("DVDRental.Supplier", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
