using Microsoft.EntityFrameworkCore.Migrations;

namespace Honzel_Family_Website.Migrations
{
    public partial class InitialMigrationWithUpdatedRecipeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecipeModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PrepTime = table.Column<int>(nullable: false),
                    CookTime = table.Column<int>(nullable: false),
                    TotalTime = table.Column<int>(nullable: false),
                    Servings = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IngredientModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    Unit = table.Column<int>(nullable: false),
                    RecipeModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IngredientModel_RecipeModel_RecipeModelID",
                        column: x => x.RecipeModelID,
                        principalTable: "RecipeModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstructionModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instruction = table.Column<string>(nullable: true),
                    RecipeModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructionModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InstructionModel_RecipeModel_RecipeModelID",
                        column: x => x.RecipeModelID,
                        principalTable: "RecipeModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuisineModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RecipeModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuisineModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QuisineModel_RecipeModel_RecipeModelID",
                        column: x => x.RecipeModelID,
                        principalTable: "RecipeModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientModel_RecipeModelID",
                table: "IngredientModel",
                column: "RecipeModelID");

            migrationBuilder.CreateIndex(
                name: "IX_InstructionModel_RecipeModelID",
                table: "InstructionModel",
                column: "RecipeModelID");

            migrationBuilder.CreateIndex(
                name: "IX_QuisineModel_RecipeModelID",
                table: "QuisineModel",
                column: "RecipeModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientModel");

            migrationBuilder.DropTable(
                name: "InstructionModel");

            migrationBuilder.DropTable(
                name: "QuisineModel");

            migrationBuilder.DropTable(
                name: "RecipeModel");
        }
    }
}
