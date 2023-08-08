using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVDRental.Migrations
{
    /// <inheritdoc />
    public partial class ConnectionAddressStaff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Address",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_StaffId",
                table: "Address",
                column: "StaffId",
                unique: true,
                filter: "[StaffId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Staffs_StaffId",
                table: "Address",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Staffs_StaffId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_StaffId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Address");
        }
    }
}
