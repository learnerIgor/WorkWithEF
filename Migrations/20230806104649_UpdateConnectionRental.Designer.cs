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
    [Migration("20230806104649_UpdateConnectionRental")]
    partial class UpdateConnectionRental
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

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

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

                    b.Property<int>("StreetId")
                        .HasColumnType("int");

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
                });

            modelBuilder.Entity("DVDRental.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int?>("RentalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("RentalId")
                        .IsUnique()
                        .HasFilter("[RentalId] IS NOT NULL");

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
                });

            modelBuilder.Entity("DVDRental.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RentalId")
                        .HasColumnType("int");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.UseTpcMappingStrategy();
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

                    b.Property<int?>("StaffId")
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

                    b.Property<int?>("CityId")
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
                });

            modelBuilder.Entity("ActorFilm", b =>
                {
                    b.HasOne("DVDRental.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVDRental.Film", null)
                        .WithMany()
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
                    b.HasOne("DVDRental.City", "City")
                        .WithMany("Address")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
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
                        .HasForeignKey("DVDRental.Inventory", "RentalId");

                    b.Navigation("Film");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("DVDRental.Payment", b =>
                {
                    b.HasOne("DVDRental.Rental", "Rental")
                        .WithMany()
                        .HasForeignKey("RentalId");

                    b.HasOne("DVDRental.Staff", "Staff")
                        .WithMany("Payments")
                        .HasForeignKey("StaffId");

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
                        .HasForeignKey("StaffId");

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
                        .HasForeignKey("CityId");

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
                    b.Navigation("Address");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("DVDRental.Country", b =>
                {
                    b.Navigation("City");
                });

            modelBuilder.Entity("DVDRental.Film", b =>
                {
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

            modelBuilder.Entity("DVDRental.Customer", b =>
                {
                    b.Navigation("Rental");
                });

            modelBuilder.Entity("DVDRental.Staff", b =>
                {
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
