using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineComplex.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuildingDetails",
                table: "Addresses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OtherDetails",
                table: "Addresses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuildingDetails",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "OtherDetails",
                table: "Addresses");
        }
    }
}
