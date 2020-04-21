using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayHomeAway.Migrations
{
    public partial class removeAva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accoms_Availabilities_AvailabilityId",
                table: "Accoms");

            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.DropIndex(
                name: "IX_Accoms_AvailabilityId",
                table: "Accoms");

            migrationBuilder.DropColumn(
                name: "AvailabilityId",
                table: "Accoms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailabilityId",
                table: "Accoms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "There is high availability for this holiday let.", "High" });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "There is some availability for this holiday let.", "Medium" });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "There is limited availability for this holiday let!", "Low" });

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 1,
                column: "AvailabilityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvailabilityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvailabilityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 4,
                column: "AvailabilityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 5,
                column: "AvailabilityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 6,
                column: "AvailabilityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 7,
                column: "AvailabilityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 8,
                column: "AvailabilityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 9,
                column: "AvailabilityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 10,
                column: "AvailabilityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 11,
                column: "AvailabilityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 12,
                column: "AvailabilityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 13,
                column: "AvailabilityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 14,
                column: "AvailabilityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 15,
                column: "AvailabilityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 16,
                column: "AvailabilityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 17,
                column: "AvailabilityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 18,
                column: "AvailabilityId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Accoms_AvailabilityId",
                table: "Accoms",
                column: "AvailabilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accoms_Availabilities_AvailabilityId",
                table: "Accoms",
                column: "AvailabilityId",
                principalTable: "Availabilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
