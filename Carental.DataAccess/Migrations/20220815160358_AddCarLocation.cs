using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carental.DataAccess.Migrations
{
    public partial class AddCarLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Location_Latitude",
                table: "Cars",
                type: "decimal(18,15)",
                precision: 18,
                scale: 15,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Location_Longitude",
                table: "Cars",
                type: "decimal(18,15)",
                precision: 18,
                scale: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location_Latitude",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Location_Longitude",
                table: "Cars");
        }
    }
}
