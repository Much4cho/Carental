using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carental.DataAccess.Migrations
{
    public partial class AddPricingAndOtherInfoColumnsToRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Rentals",
                newName: "TotalKmMade");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedOnUtc",
                table: "Rentals",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RentedOnUtc",
                table: "Rentals",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosedOnUtc",
                table: "Rentals",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LastLocation_Latitude",
                table: "Rentals",
                type: "decimal(18,15)",
                precision: 18,
                scale: 15,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LastLocation_Longitude",
                table: "Rentals",
                type: "decimal(18,15)",
                precision: 18,
                scale: 15,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ParkedPricePerMinute",
                table: "Rentals",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PricePerKilometer",
                table: "Rentals",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PricePerMinute",
                table: "Rentals",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservedOnUtc",
                table: "Rentals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TotalTimeDriving",
                table: "Rentals",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TotalTimeParked",
                table: "Rentals",
                type: "time",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosedOnUtc",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "LastLocation_Latitude",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "LastLocation_Longitude",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "ParkedPricePerMinute",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "PricePerKilometer",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "PricePerMinute",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "ReservedOnUtc",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "TotalTimeDriving",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "TotalTimeParked",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "TotalKmMade",
                table: "Rentals",
                newName: "TotalPrice");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedOnUtc",
                table: "Rentals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RentedOnUtc",
                table: "Rentals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
