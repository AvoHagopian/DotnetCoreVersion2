using Microsoft.EntityFrameworkCore.Migrations;

namespace PantheonBackend.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    area = table.Column<float>(nullable: false),
                    population = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "God",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryID = table.Column<int>(nullable: false),
                    CountryName = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    power = table.Column<string>(nullable: true),
                    symbol = table.Column<string>(nullable: true),
                    animal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_God", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hero",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GodID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false),
                    GodName = table.Column<string>(nullable: true),
                    CountryName = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    victories = table.Column<int>(nullable: false),
                    losses = table.Column<int>(nullable: false),
                    weapon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hero", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "God");

            migrationBuilder.DropTable(
                name: "Hero");
        }
    }
}
