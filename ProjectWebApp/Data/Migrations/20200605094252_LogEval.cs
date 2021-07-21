using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWebApp.Data.Migrations
{
    public partial class LogEval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    PricePerItem = table.Column<int>(nullable: false),
                    Purpose = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NegPoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Point = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NegPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NegPoints_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosPoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Point = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosPoints_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resource = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profits_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ProjectId",
                table: "Expenses",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_NegPoints_ProjectId",
                table: "NegPoints",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PosPoints_ProjectId",
                table: "PosPoints",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Profits_ProjectId",
                table: "Profits",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "NegPoints");

            migrationBuilder.DropTable(
                name: "PosPoints");

            migrationBuilder.DropTable(
                name: "Profits");
        }
    }
}
