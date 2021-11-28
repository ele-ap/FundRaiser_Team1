using Microsoft.EntityFrameworkCore.Migrations;

namespace FundRaiser_Team1.Migrations
{
    public partial class projectInstances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Creator_ProjectCreatorId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectCreatorId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectCreatorId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "CreatedProjectId",
                table: "Creator",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Creator_CreatedProjectId",
                table: "Creator",
                column: "CreatedProjectId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Creator_Projects_CreatedProjectId",
                table: "Creator",
                column: "CreatedProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Creator_Projects_CreatedProjectId",
                table: "Creator");

            migrationBuilder.DropIndex(
                name: "IX_Creator_CreatedProjectId",
                table: "Creator");

            migrationBuilder.DropColumn(
                name: "CreatedProjectId",
                table: "Creator");

            migrationBuilder.AddColumn<int>(
                name: "ProjectCreatorId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectCreatorId",
                table: "Projects",
                column: "ProjectCreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Creator_ProjectCreatorId",
                table: "Projects",
                column: "ProjectCreatorId",
                principalTable: "Creator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
