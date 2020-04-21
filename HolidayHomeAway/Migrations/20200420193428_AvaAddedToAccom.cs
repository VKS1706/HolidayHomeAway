using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayHomeAway.Migrations
{
    public partial class AvaAddedToAccom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvailabilityType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvailabilityType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 4,
                column: "AvailabilityType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 6,
                column: "AvailabilityType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 7,
                column: "AvailabilityType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 8,
                column: "AvailabilityType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 9,
                column: "AvailabilityType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 11,
                column: "AvailabilityType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 13,
                column: "AvailabilityType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 15,
                column: "AvailabilityType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 17,
                column: "AvailabilityType",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 4,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 6,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 7,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 8,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 9,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 11,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 13,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 15,
                column: "AvailabilityType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 17,
                column: "AvailabilityType",
                value: 0);
        }
    }
}
