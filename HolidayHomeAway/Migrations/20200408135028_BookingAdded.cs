using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayHomeAway.Migrations
{
    public partial class BookingAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingItems",
                columns: table => new
                {
                    BookingItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccomId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    BookingId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingItems", x => x.BookingItemId);
                    table.ForeignKey(
                        name: "FK_BookingItems_Accoms_AccomId",
                        column: x => x.AccomId,
                        principalTable: "Accoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingItems_AccomId",
                table: "BookingItems",
                column: "AccomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingItems");
        }
    }
}
