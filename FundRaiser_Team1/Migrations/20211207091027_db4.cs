using Microsoft.EntityFrameworkCore.Migrations;

namespace FundRaiser_Team1.Migrations
{
    public partial class db4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Package_Projects_ProjectId",
                table: "Package");

            migrationBuilder.DropIndex(
                name: "IX_Package_ProjectId",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Package");

            migrationBuilder.CreateTable(
                name: "PackageProject",
                columns: table => new
                {
                    AwardPackagesId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageProject", x => new { x.AwardPackagesId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_PackageProject_Package_AwardPackagesId",
                        column: x => x.AwardPackagesId,
                        principalTable: "Package",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageProject_ProjectsId",
                table: "PackageProject",
                column: "ProjectsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageProject");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Package",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Package_ProjectId",
                table: "Package",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Projects_ProjectId",
                table: "Package",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
