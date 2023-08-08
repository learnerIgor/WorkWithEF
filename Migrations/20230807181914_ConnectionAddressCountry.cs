using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DVDRental.Migrations
{
    /// <inheritdoc />
    public partial class ConnectionAddressCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Cities_CityId",
                table: "Address");

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

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Address",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CityId",
                table: "Address",
                newName: "IX_Address_CountryId");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdate",
                value: new DateTime(2023, 8, 7, 21, 19, 14, 290, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Countries_CountryId",
                table: "Address",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Countries_CountryId",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Address",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CountryId",
                table: "Address",
                newName: "IX_Address_CityId");

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
                value: new DateTime(2023, 8, 7, 20, 51, 31, 763, DateTimeKind.Local).AddTicks(4796));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Cities_CityId",
                table: "Address",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
