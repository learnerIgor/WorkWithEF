using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVDRental.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConnectionRental : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryFilm_Category_CategoryId",
                table: "CategoryFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Rental_RentalId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Rental_RentalId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Staffs_StaffId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Rental_Customers_CustomerId",
                table: "Rental");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rental",
                table: "Rental");

            migrationBuilder.DropIndex(
                name: "IX_Rental_CustomerId",
                table: "Rental");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Rental",
                newName: "Rentals");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_StaffId",
                table: "Payments",
                newName: "IX_Payments_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_RentalId",
                table: "Payments",
                newName: "IX_Payments_RentalId");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Rentals",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_StaffId",
                table: "Rentals",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryFilm_Categories_CategoryId",
                table: "CategoryFilm",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Rentals_RentalId",
                table: "Inventories",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Rentals_RentalId",
                table: "Payments",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Staffs_StaffId",
                table: "Payments",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Staffs_StaffId",
                table: "Rentals",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryFilm_Categories_CategoryId",
                table: "CategoryFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Rentals_RentalId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Rentals_RentalId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Staffs_StaffId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Customers_CustomerId",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Staffs_StaffId",
                table: "Rentals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_StaffId",
                table: "Rentals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Rentals");

            migrationBuilder.RenameTable(
                name: "Rentals",
                newName: "Rental");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_StaffId",
                table: "Payment",
                newName: "IX_Payment_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_RentalId",
                table: "Payment",
                newName: "IX_Payment_RentalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rental",
                table: "Rental",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_CustomerId",
                table: "Rental",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryFilm_Category_CategoryId",
                table: "CategoryFilm",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Rental_RentalId",
                table: "Inventories",
                column: "RentalId",
                principalTable: "Rental",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Rental_RentalId",
                table: "Payment",
                column: "RentalId",
                principalTable: "Rental",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Staffs_StaffId",
                table: "Payment",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rental_Customers_CustomerId",
                table: "Rental",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
