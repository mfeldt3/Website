using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Michael.Migrations
{
    public partial class InitialCompletedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParkNumber",
                table: "ParkLists",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParkNumber",
                table: "ParkLists");
        }
    }
}
