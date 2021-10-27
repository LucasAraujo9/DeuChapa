using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeuChapa.Migrations
{
    public partial class MeuDbChapa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bebida",
                columns: table => new
                {
                    Id_Bebida = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebida", x => x.Id_Bebida);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id_Ingrediente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pao = table.Column<string>(nullable: true),
                    Hamburguer = table.Column<string>(nullable: true),
                    Queijo = table.Column<string>(nullable: true),
                    Molho = table.Column<string>(nullable: true),
                    Tomate = table.Column<bool>(nullable: false),
                    Alface = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id_Ingrediente);
                });

            migrationBuilder.CreateTable(
                name: "Lanche",
                columns: table => new
                {
                    Id_Lanche = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    IngredientesId_Ingrediente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanche", x => x.Id_Lanche);
                    table.ForeignKey(
                        name: "FK_Lanche_Ingredientes_IngredientesId_Ingrediente",
                        column: x => x.IngredientesId_Ingrediente,
                        principalTable: "Ingredientes",
                        principalColumn: "Id_Ingrediente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Combo",
                columns: table => new
                {
                    Id_Combo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LancheId_Lanche = table.Column<int>(nullable: true),
                    BebidaId_Bebida = table.Column<int>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combo", x => x.Id_Combo);
                    table.ForeignKey(
                        name: "FK_Combo_Bebida_BebidaId_Bebida",
                        column: x => x.BebidaId_Bebida,
                        principalTable: "Bebida",
                        principalColumn: "Id_Bebida",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Combo_Lanche_LancheId_Lanche",
                        column: x => x.LancheId_Lanche,
                        principalTable: "Lanche",
                        principalColumn: "Id_Lanche",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Combo_BebidaId_Bebida",
                table: "Combo",
                column: "BebidaId_Bebida");

            migrationBuilder.CreateIndex(
                name: "IX_Combo_LancheId_Lanche",
                table: "Combo",
                column: "LancheId_Lanche");

            migrationBuilder.CreateIndex(
                name: "IX_Lanche_IngredientesId_Ingrediente",
                table: "Lanche",
                column: "IngredientesId_Ingrediente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Combo");

            migrationBuilder.DropTable(
                name: "Bebida");

            migrationBuilder.DropTable(
                name: "Lanche");

            migrationBuilder.DropTable(
                name: "Ingredientes");
        }
    }
}
