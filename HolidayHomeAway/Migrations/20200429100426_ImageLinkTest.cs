using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayHomeAway.Migrations
{
    public partial class ImageLinkTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~Images\\AmblesideCara_Out.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accoms",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "Images\\AmblesideCara_Out.jpg");
        }
    }
}
