using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayHomeAway.Migrations
{
    public partial class ImageURLChangeTestpt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "HolidayHomeAway\\wwwroot\\Images\\CanterburyLodge.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\CanterburyLodge.jpg");
        }
    }
}
