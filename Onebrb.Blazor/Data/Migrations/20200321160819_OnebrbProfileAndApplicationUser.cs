using Microsoft.EntityFrameworkCore.Migrations;

namespace Onebrb.Blazor.Data.Migrations
{
    public partial class OnebrbProfileAndApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OnebrbProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    About = table.Column<string>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnebrbProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnebrbProfiles_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OnebrbProfiles_ApplicationUserId",
                table: "OnebrbProfiles",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnebrbProfiles");
        }
    }
}
