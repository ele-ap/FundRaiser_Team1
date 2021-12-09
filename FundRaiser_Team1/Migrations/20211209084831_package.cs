using Microsoft.EntityFrameworkCore.Migrations;

namespace FundRaiser_Team1.Migrations
{
    public partial class package : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "PackageUser",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "PackageUser");
        }
    }
}
