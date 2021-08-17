﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservationRestApi.Model;

namespace ReservationRestApi.Migrations
{
    [DbContext(typeof(ReservationContext))]
    [Migration("20210817040347_SeedData3")]
    partial class SeedData3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReservationRestApi.Model.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<double?>("PostalCode")
                        .HasColumnType("float");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuestId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            GuestId = 101,
                            Email = "john@gmail.com",
                            LastName = "Honnai",
                            Name = "John",
                            ReservationId = 101
                        },
                        new
                        {
                            GuestId = 102,
                            Email = "adam@gmail.com",
                            LastName = "Mathew",
                            Name = "Adam",
                            ReservationId = 102
                        },
                        new
                        {
                            GuestId = 103,
                            Email = "billy@gmail.com",
                            LastName = "Brown",
                            Name = "Billy",
                            ReservationId = 103
                        },
                        new
                        {
                            GuestId = 104,
                            Email = "cristopher@gmail.com",
                            LastName = "Luis",
                            Name = "Cristopher",
                            ReservationId = 104
                        },
                        new
                        {
                            GuestId = 105,
                            Email = "boss@gmail.com",
                            LastName = "Mathew",
                            Name = "Boss",
                            ReservationId = 105
                        });
                });

            modelBuilder.Entity("ReservationRestApi.Model.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("date");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ReservationCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal?>("commission")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 101,
                            CheckInDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(7770),
                            CheckOutDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(7780),
                            CreationDate = new DateTime(2021, 8, 17, 6, 3, 46, 52, DateTimeKind.Local).AddTicks(5200),
                            Currency = "PLN",
                            Price = 120.0,
                            ReservationCode = "Qwertyuw"
                        },
                        new
                        {
                            ReservationId = 102,
                            CheckInDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9660),
                            CheckOutDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9670),
                            CreationDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9650),
                            Currency = "PLN",
                            Price = 150.0,
                            ReservationCode = "Asdfghje"
                        },
                        new
                        {
                            ReservationId = 103,
                            CheckInDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9960),
                            CheckOutDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9970),
                            CreationDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9960),
                            Currency = "PLN",
                            Price = 100.0,
                            ReservationCode = "Zxcvbnm"
                        },
                        new
                        {
                            ReservationId = 104,
                            CheckInDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9970),
                            CheckOutDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9970),
                            CreationDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9970),
                            Currency = "PLN",
                            Price = 180.0,
                            ReservationCode = "Lkjhgfds"
                        },
                        new
                        {
                            ReservationId = 105,
                            CheckInDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9980),
                            CheckOutDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9980),
                            CreationDate = new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9980),
                            Currency = "PLN",
                            Price = 200.0,
                            ReservationCode = "Oiuytrew"
                        });
                });

            modelBuilder.Entity("ReservationRestApi.Model.Guest", b =>
                {
                    b.HasOne("ReservationRestApi.Model.Reservation", "Reservation")
                        .WithMany("Guest")
                        .HasForeignKey("ReservationId")
                        .HasConstraintName("FK_Guest_Reservation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("ReservationRestApi.Model.Reservation", b =>
                {
                    b.Navigation("Guest");
                });
#pragma warning restore 612, 618
        }
    }
}