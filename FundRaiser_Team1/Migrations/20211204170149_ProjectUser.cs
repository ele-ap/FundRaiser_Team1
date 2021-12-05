using Microsoft.EntityFrameworkCore.Migrations;

namespace FundRaiser_Team1.Migrations
{
    public partial class ProjectUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "ProjectUser",
                newName: "CategoryProject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryProject",
                table: "ProjectUser",
                newName: "Category");
        }
    }
}
