using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name" },
                values: new object[,]
                {
                    { 1, "Monterrey, Nuevo Leon, Mexico" },
                    { 2, "Monterrey, Casanare, Colombia" },
                    { 3, "Monterrey, Cortes, Honduras" },
                    { 4, "Monterrey, Bio-Bio, Chile" },
                    { 5, "Monterrey, Asturias, Spain" },
                    { 6, "Monterrey, Magdalena, Colombia" },
                    { 7, "Monterrey, Tamaulipas, Mexico" },
                    { 8, "Monterrey, Campeche, Mexico" },
                    { 9, "Monterrey, Tabasco, Mexico" },
                    { 10, "Monterrey, Chiapas, Mexico" },
                    { 11, "Monterrey, Francisco Morazan, Honduras" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
