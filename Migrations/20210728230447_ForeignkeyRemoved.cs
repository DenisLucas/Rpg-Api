using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class ForeignkeyRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Inventario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Inventario",
                type: "int",
                nullable: true);
        }
    }
}
