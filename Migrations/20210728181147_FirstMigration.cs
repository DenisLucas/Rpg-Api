using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Magico = table.Column<bool>(type: "bit", nullable: false),
                    Equipavel = table.Column<bool>(type: "bit", nullable: false),
                    passivo = table.Column<bool>(type: "bit", nullable: false),
                    Efeito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeusAfiliado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hp = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Xp = table.Column<float>(type: "real", nullable: false),
                    NextLevel = table.Column<float>(type: "real", nullable: false),
                    Força = table.Column<int>(type: "int", nullable: false),
                    Defesa = table.Column<int>(type: "int", nullable: false),
                    Agilidade = table.Column<int>(type: "int", nullable: false),
                    Inteligencia = table.Column<int>(type: "int", nullable: false),
                    Magia = table.Column<int>(type: "int", nullable: false),
                    Fé = table.Column<int>(type: "int", nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Itensid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Inventario_Itens_Itensid",
                        column: x => x.Itensid,
                        principalTable: "Itens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventario_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_Itensid",
                table: "Inventario",
                column: "Itensid");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_PlayerId",
                table: "Inventario",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
