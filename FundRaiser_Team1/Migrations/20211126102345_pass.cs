using Microsoft.EntityFrameworkCore.Migrations;

namespace FundRaiser_Team1.Migrations
{
    public partial class pass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Creator",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Backer",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Creator");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Backer");
        }
    }
}
