using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryZooApplication.Migrations
{
    public partial class AnimalSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Species", "Weight" },
                values: new object[] { "Frog", "Amphibian", 0.10000000000000001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Species", "Weight" },
                values: new object[] { "Rabbit", "Mammel", 1.2 });
        }
    }
}
