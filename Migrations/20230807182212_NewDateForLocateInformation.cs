using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DVDRental.Migrations
{
    /// <inheritdoc />
    public partial class NewDateForLocateInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "NameCountry" },
                values: new object[,]
                {
                    { 1, "England" },
                    { 2, "Belarus" }
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdate",
                value: new DateTime(2023, 8, 7, 21, 22, 12, 372, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "NameCity" },
                values: new object[,]
                {
                    { 1, 1, "London" },
                    { 2, 2, "Minsk" }
                });

            migrationBuilder.InsertData(
                table: "Streets",
                columns: new[] { "Id", "CityId", "HouseNumber", "NameStreet" },
                values: new object[,]
                {
                    { 1, 1, 12, "The Mall" },
                    { 2, 2, 13, "Maxim Bogdanovich" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdate",
                value: new DateTime(2023, 8, 7, 21, 19, 14, 290, DateTimeKind.Local).AddTicks(6997));
        }
    }
}
