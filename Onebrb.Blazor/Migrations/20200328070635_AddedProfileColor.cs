using Microsoft.EntityFrameworkCore.Migrations;

namespace Onebrb.Blazor.Migrations
{
    public partial class AddedProfileColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileColor",
                table: "OnebrbProfiles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileColor",
                table: "OnebrbProfiles");
        }
    }
}
