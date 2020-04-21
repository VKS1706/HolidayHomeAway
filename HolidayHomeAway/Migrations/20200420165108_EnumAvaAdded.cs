﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayHomeAway.Migrations
{
    public partial class EnumAvaAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailabilityType",
                table: "Accoms",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailabilityType",
                table: "Accoms");
        }
    }
}
