using Microsoft.EntityFrameworkCore.Migrations;

namespace AstroWorldZodiac.Data.Migrations
{
    public partial class AddGemStoreIdInAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "GemStoneId",
                table: "Appointments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_GemStoneId",
                table: "Appointments",
                column: "GemStoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_GemStone_GemStoneId",
                table: "Appointments",
                column: "GemStoneId",
                principalTable: "GemStone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_GemStone_GemStoneId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_GemStoneId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "GemStoneId",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
