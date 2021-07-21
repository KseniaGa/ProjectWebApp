using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebApp.Data.Migrations
{
    public partial class Kanban3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "done",
                table: "Tasks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "process",
                table: "Tasks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "todo",
                table: "Tasks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "done",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "process",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "todo",
                table: "Tasks");
        }
    }
}
