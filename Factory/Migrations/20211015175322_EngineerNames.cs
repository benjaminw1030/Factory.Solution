using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class EngineerNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Engineers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Engineers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Engineers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Engineers",
                newName: "Name");
        }
    }
}
