using Microsoft.EntityFrameworkCore.Migrations;

namespace Onebrb.Blazor.Migrations
{
    public partial class Social : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "OnebrbProfiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "OnebrbProfiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "OnebrbProfiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "OnebrbProfiles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "OnebrbProfiles");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "OnebrbProfiles");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "OnebrbProfiles");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "OnebrbProfiles");
        }
    }
}
