using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MadPlanner.Migrations
{
    /// <inheritdoc />
    public partial class BaseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Madplaner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Week = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Madplaner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produkter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    PackingType = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Grams = table.Column<int>(type: "INTEGER", nullable: false),
                    Calories = table.Column<int>(type: "INTEGER", nullable: false),
                    Butik = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Retter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    Vegetarian = table.Column<bool>(type: "INTEGER", nullable: false),
                    PorkBased = table.Column<bool>(type: "INTEGER", nullable: false),
                    Leftovers = table.Column<bool>(type: "INTEGER", nullable: false),
                    Takeaway = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsPublic = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredienser",
                columns: table => new
                {
                    RetId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProduktId = table.Column<int>(type: "INTEGER", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    Grams = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredienser", x => new { x.RetId, x.ProduktId });
                    table.ForeignKey(
                        name: "FK_Ingredienser_Produkter_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredienser_Retter_RetId",
                        column: x => x.RetId,
                        principalTable: "Retter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MadplanRetter",
                columns: table => new
                {
                    MadplanId = table.Column<int>(type: "INTEGER", nullable: false),
                    RetId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MadplanRetter", x => new { x.MadplanId, x.RetId });
                    table.ForeignKey(
                        name: "FK_MadplanRetter_Madplaner_MadplanId",
                        column: x => x.MadplanId,
                        principalTable: "Madplaner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MadplanRetter_Retter_RetId",
                        column: x => x.RetId,
                        principalTable: "Retter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredienser_ProduktId",
                table: "Ingredienser",
                column: "ProduktId");

            migrationBuilder.CreateIndex(
                name: "IX_MadplanRetter_RetId",
                table: "MadplanRetter",
                column: "RetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredienser");

            migrationBuilder.DropTable(
                name: "MadplanRetter");

            migrationBuilder.DropTable(
                name: "Produkter");

            migrationBuilder.DropTable(
                name: "Madplaner");

            migrationBuilder.DropTable(
                name: "Retter");
        }
    }
}
