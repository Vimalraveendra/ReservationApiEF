using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationRestApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CheckInDate", "CheckOutDate", "CreationDate", "Currency", "Price", "ReservationCode", "commission" },
                values: new object[] { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PLN", 120.0, "Qwertyuw", null });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "GuestId", "DOB", "Email", "LastName", "Name", "PostalCode", "ReservationId" },
                values: new object[] { 101, null, "john@gmail.com", "Honnai", "John", null, 101 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 101);
        }
    }
}
