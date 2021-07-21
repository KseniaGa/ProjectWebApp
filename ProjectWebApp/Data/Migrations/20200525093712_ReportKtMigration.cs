using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebApp.Data.Migrations
{
    public partial class ReportKtMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KTs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameofUser = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    PositionExp = table.Column<string>(nullable: true),
                    TeamExp = table.Column<string>(nullable: true),
                    ImprovementPoints = table.Column<string>(nullable: true),
                    ThingsToKeep = table.Column<string>(nullable: true),
                    FinalAdvice = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KTs_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameofUser = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KTs_ProjectId",
                table: "KTs",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ProjectId",
                table: "Reports",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KTs");

            migrationBuilder.DropTable(
                name: "Reports");
        }
    }
}
