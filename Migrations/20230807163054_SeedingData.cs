using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DVDRental.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Stores_StoreId",
                table: "Staffs");

            migrationBuilder.AlterColumn<int>(
                name: "StoreId",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name", "Phone", "Popularity", "Surname" },
                values: new object[] { 3, "Oscar", 5646757, true, "Wilson" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "LastUpdate" },
                values: new object[] { 1, "Crime", new DateTime(1994, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LastUpdate", "NameLanguage" },
                values: new object[] { 1, new DateTime(2023, 8, 7, 19, 30, 54, 198, DateTimeKind.Local).AddTicks(2417), "Russia" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name", "Phone", "Surname" },
                values: new object[,]
                {
                    { 1, "Mark", 12345, "Simpson" },
                    { 2, "Sam", 1357, "Adamson" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "BankDetails", "LastDelivery", "LegalForm", "Name", "Phone", "Reliability", "Surname" },
                values: new object[] { 4, "12345BY5345DF", new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "LLC", "Samuel", 12342435, true, "Aldridge" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Description", "FullText", "LanguageId", "Length", "Rating", "ReleaseYear", "RentalDuration", "RentalRate", "ReplacementCost", "SupplierId", "Title" },
                values: new object[] { 1, "The plot is composed of several stories", "The plot is composed of several stories", 1, 154, 10, new DateTime(1994, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 10f, 50, 4, "Pulp Fiction" });

            migrationBuilder.InsertData(
                table: "ActorFilm",
                columns: new[] { "ActorId", "FilmId" },
                values: new object[] { 3, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Stores_StoreId",
                table: "Staffs",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Stores_StoreId",
                table: "Staffs");

            migrationBuilder.DeleteData(
                table: "ActorFilm",
                keyColumns: new[] { "ActorId", "FilmId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "StoreId",
                table: "Staffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "ActorFilms",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId1 = table.Column<int>(type: "int", nullable: true),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorFilms", x => x.ActorId);
                    table.ForeignKey(
                        name: "FK_ActorFilms_Actors_ActorId1",
                        column: x => x.ActorId1,
                        principalTable: "Actors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActorFilms_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorFilms_ActorId1",
                table: "ActorFilms",
                column: "ActorId1");

            migrationBuilder.CreateIndex(
                name: "IX_ActorFilms_FilmId",
                table: "ActorFilms",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Stores_StoreId",
                table: "Staffs",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");
        }
    }
}
