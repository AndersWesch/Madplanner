using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MadPlanner.Migrations
{
    /// <inheritdoc />
    public partial class produktInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Produkter",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<int>(
                name: "Butik",
                table: "Produkter",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Produkter",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Butik",
                table: "Produkter");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Produkter");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Produkter",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);
        }
    }
}
