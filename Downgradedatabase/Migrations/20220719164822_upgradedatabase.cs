using Microsoft.EntityFrameworkCore.Migrations;

namespace Downgradedatabase.Migrations
{
    public partial class upgradedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "section",
                table: "student1",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "section",
                table: "student1");
        }
    }
}
