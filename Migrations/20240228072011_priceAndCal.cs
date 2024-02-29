using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MadPlanner.Migrations
{
    /// <inheritdoc />
    public partial class priceAndCal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Calories",
                table: "Madplaner",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Madplaner",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0)
                .Annotation("Relational:ColumnOrder", 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "Madplaner");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Madplaner");
        }
    }
}
