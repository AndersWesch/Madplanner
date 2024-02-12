using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MadPlanner.Migrations
{
    /// <inheritdoc />
    public partial class takeawayBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Takeway",
                table: "Retter",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Takeway",
                table: "Retter");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Produkter",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");
        }
    }
}
