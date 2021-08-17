using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationRestApi.Migrations
{
    public partial class SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 101,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(7770), new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(7780), new DateTime(2021, 8, 17, 6, 3, 46, 52, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 102,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9660), new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9670), new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 103,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9960), new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9970), new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 104,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9970), new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9970), new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 105,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9980), new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9980), new DateTime(2021, 8, 17, 6, 3, 46, 58, DateTimeKind.Local).AddTicks(9980) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Guests");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 101,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(2530), new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(2550), new DateTime(2021, 8, 17, 0, 7, 49, 44, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 102,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4370), new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4370), new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 103,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4410), new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4420), new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 104,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4420), new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4420), new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 105,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4430), new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4430), new DateTime(2021, 8, 17, 0, 7, 49, 51, DateTimeKind.Local).AddTicks(4430) });
        }
    }
}
