using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVDRental.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAddingConnectionRI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_RentalId",
                table: "Inventories",
                column: "RentalId",
                unique: true,
                filter: "[RentalId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Rental_RentalId",
                table: "Inventories",
                column: "RentalId",
                principalTable: "Rental",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Rental_RentalId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_RentalId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "Inventories");
        }
    }
}
