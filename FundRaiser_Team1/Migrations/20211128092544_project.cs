using Microsoft.EntityFrameworkCore.Migrations;

namespace FundRaiser_Team1.Migrations
{
    public partial class project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Backer_BackerId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Creator_CreatorId",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_BackerId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "BackerId",
                table: "Project");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameColumn(
                name: "CreatorId",
                table: "Projects",
                newName: "ProjectCreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_CreatorId",
                table: "Projects",
                newName: "IX_Projects_ProjectCreatorId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusPost",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BackerProject",
                columns: table => new
                {
                    BackersId = table.Column<int>(type: "int", nullable: false),
                    FundedProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackerProject", x => new { x.BackersId, x.FundedProjectsId });
                    table.ForeignKey(
                        name: "FK_BackerProject_Backer_BackersId",
                        column: x => x.BackersId,
                        principalTable: "Backer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackerProject_Projects_FundedProjectsId",
                        column: x => x.FundedProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackerProject_FundedProjectsId",
                table: "BackerProject",
                column: "FundedProjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Creator_ProjectCreatorId",
                table: "Projects",
                column: "ProjectCreatorId",
                principalTable: "Creator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Creator_ProjectCreatorId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "BackerProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StatusPost",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameColumn(
                name: "ProjectCreatorId",
                table: "Project",
                newName: "CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ProjectCreatorId",
                table: "Project",
                newName: "IX_Project_CreatorId");

            migrationBuilder.AddColumn<int>(
                name: "BackerId",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Project_BackerId",
                table: "Project",
                column: "BackerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Backer_BackerId",
                table: "Project",
                column: "BackerId",
                principalTable: "Backer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Creator_CreatorId",
                table: "Project",
                column: "CreatorId",
                principalTable: "Creator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
