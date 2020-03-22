using Microsoft.EntityFrameworkCore.Migrations;

namespace Onebrb.Blazor.Migrations
{
    public partial class SocialAddedLinkedIn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkedIn",
                table: "OnebrbProfiles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkedIn",
                table: "OnebrbProfiles");
        }
    }
}
