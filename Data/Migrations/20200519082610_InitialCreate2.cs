using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DNC6.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                schema: "dbo",
                table: "Student",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                schema: "dbo",
                table: "Student",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Gender",
                schema: "dbo",
                table: "Student");
        }
    }
}
