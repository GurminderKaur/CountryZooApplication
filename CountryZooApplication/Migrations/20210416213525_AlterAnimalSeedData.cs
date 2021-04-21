using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryZooApplication.Migrations
{
    public partial class AlterAnimalSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Name", "Species", "Weight" },
                values: new object[] { 2, "Rabbit", "Mammel", 1.2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
