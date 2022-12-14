// <auto-generated />
using System;
using Carental.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Carental.DataAccess.Migrations
{
    [DbContext(typeof(CarentalContext))]
    [Migration("20221106182828_AddPricingAndOtherInfoColumnsToRental")]
    partial class AddPricingAndOtherInfoColumnsToRental
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Carental.DataAccess.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModelYear")
                        .HasColumnType("int");

                    b.Property<decimal>("ParkedPricePerMinute")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerKilometer")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PricePerMinute")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("RenterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RenterId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Carental.DataAccess.Entities.Rental", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ClosedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ParkedPricePerMinute")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PricePerKilometer")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PricePerMinute")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RentedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalKmMade")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeSpan?>("TotalTimeDriving")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("TotalTimeParked")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Carental.DataAccess.Entities.Renter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Renters");
                });

            modelBuilder.Entity("Carental.DataAccess.Entities.Car", b =>
                {
                    b.HasOne("Carental.DataAccess.Entities.Renter", "Renter")
                        .WithMany("Cars")
                        .HasForeignKey("RenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Carental.DataAccess.Entities.Location", "Location", b1 =>
                        {
                            b1.Property<Guid>("CarId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Latitude")
                                .HasPrecision(18, 15)
                                .HasColumnType("decimal(18,15)");

                            b1.Property<decimal>("Longitude")
                                .HasPrecision(18, 15)
                                .HasColumnType("decimal(18,15)");

                            b1.HasKey("CarId");

                            b1.ToTable("Cars");

                            b1.WithOwner()
                                .HasForeignKey("CarId");
                        });

                    b.Navigation("Location");

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("Carental.DataAccess.Entities.Rental", b =>
                {
                    b.HasOne("Carental.DataAccess.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Carental.DataAccess.Entities.Location", "LastLocation", b1 =>
                        {
                            b1.Property<Guid>("RentalId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Latitude")
                                .HasPrecision(18, 15)
                                .HasColumnType("decimal(18,15)");

                            b1.Property<decimal>("Longitude")
                                .HasPrecision(18, 15)
                                .HasColumnType("decimal(18,15)");

                            b1.HasKey("RentalId");

                            b1.ToTable("Rentals");

                            b1.WithOwner()
                                .HasForeignKey("RentalId");
                        });

                    b.Navigation("Car");

                    b.Navigation("LastLocation");
                });

            modelBuilder.Entity("Carental.DataAccess.Entities.Renter", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
