using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationRestApi.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Reservations_ReservationId",
                table: "Guests");

            migrationBuilder.AlterColumn<string>(
                name: "ReservationCode",
                table: "Reservations",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reservations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "Reservations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "Reservations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guests",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Guests",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Guests",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_Reservation",
                table: "Guests",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_Reservation",
                table: "Guests");

            migrationBuilder.AlterColumn<string>(
                name: "ReservationCode",
                table: "Reservations",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOutDate",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckInDate",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Guests",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 101,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 102,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 103,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 104,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 105,
                columns: new[] { "CheckInDate", "CheckOutDate", "CreationDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Reservations_ReservationId",
                table: "Guests",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
