using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DVDRental.Migrations
{
    /// <inheritdoc />
    public partial class SeedingNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdate",
                value: new DateTime(2023, 8, 7, 20, 37, 44, 800, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "BankDetails", "LastDelivery", "LegalForm", "Name", "Phone", "Reliability", "Surname" },
                values: new object[] { 5, "BY345BY5345DF", new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "IE", "Tom", 12342, true, "Robertson" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Description", "FullText", "LanguageId", "Length", "Rating", "ReleaseYear", "RentalDuration", "RentalRate", "ReplacementCost", "SupplierId", "Title" },
                values: new object[,]
                {
                    { 2, "Characters dream of hitting the 'big jackpot'", "Characters dream of hitting the 'big jackpot'", 1, 102, 10, new DateTime(1999, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10f, 60, 5, "Snatch" },
                    { 3, "The film is set in London.", "Lock, Stock and Two Smoking Barrels", 1, 107, 10, new DateTime(1997, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10f, 100, 5, "Lock, Stock and Two Smoking Barrels" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdate",
                value: new DateTime(2023, 8, 7, 20, 8, 4, 858, DateTimeKind.Local).AddTicks(5214));
        }
    }
}
