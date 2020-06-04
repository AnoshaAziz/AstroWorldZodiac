using Microsoft.EntityFrameworkCore.Migrations;

namespace AstroWorldZodiac.Data.Migrations
{
    public partial class GemStoneAddedInApplicationDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GemStone",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable.", "Ruby" },
                    { 2, "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable.", "Pearl" },
                    { 3, "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable.", "Red Coral" },
                    { 4, "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable.", "Emerald" },
                    { 5, "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable.", "Topaz" },
                    { 6, "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable.", "Diamond" },
                    { 7, "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable.", "Yellow Sapphire" },
                    { 8, "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable.", "Blue Sapphire" },
                    { 9, "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable.", "Cat's Eyes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GemStone",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GemStone",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GemStone",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GemStone",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GemStone",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GemStone",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GemStone",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GemStone",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GemStone",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
