using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Michael.Migrations
{
    public partial class Initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkLists",
                columns: table => new
                {
                    ParkListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkLists", x => x.ParkListId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkLists");
        }
    }
}
