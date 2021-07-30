using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class ForeignkeyInv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Inventario",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Inventario");
        }
    }
}
