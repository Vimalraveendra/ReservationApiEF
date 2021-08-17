using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationRestApi.Migrations
{
    public partial class SeedData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "commission",
                table: "Reservations",
                newName: "Commission");

            migrationBuilder.AlterColumn<decimal>(
                name: "Commission",
                table: "Reservations",
                type: "decimal(16,3)",
                precision: 16,
                scale: 3,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 101,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(5590), new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(5600), new DateTime(2021, 8, 17, 6, 9, 50, 914, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 102,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7390), new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7390), new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 103,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7430), new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7430), new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 104,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7440), new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7440), new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 105,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7450), new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7450), new DateTime(2021, 8, 17, 6, 9, 50, 920, DateTimeKind.Local).AddTicks(7450) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Commission",
                table: "Reservations",
                newName: "commission");

            migrationBuilder.AlterColumn<decimal>(
                name: "commission",
                table: "Reservations",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,3)",
                oldPrecision: 16,
                oldScale: 3,
                oldNullable: true);

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
    }
}
