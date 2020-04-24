using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayHomeAway.Migrations
{
    public partial class ImageURLChangeTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "Images\\AmblesideCara_Out.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "C:\\Users\\vikki\\source\\repos\\HolidayHomeAway\\HolidayHomeAway\\wwwroot\\Images\\AmblesideCara_Out.jpg");
        }
    }
}
