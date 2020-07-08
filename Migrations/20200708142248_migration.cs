using Microsoft.EntityFrameworkCore.Migrations;

namespace SiteRando.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hike",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Distance = table.Column<int>(nullable: false),
                    Time = table.Column<int>(nullable: false),
                    Elevation = table.Column<int>(nullable: false),
                    Difficult = table.Column<int>(nullable: false),
                    StartDetails = table.Column<string>(nullable: false),
                    EndDetails = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: false),
                    Map = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hike", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hike");
        }
    }
}
