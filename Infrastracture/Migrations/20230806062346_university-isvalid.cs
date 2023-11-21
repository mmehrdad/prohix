using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prohix.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class universityisvalid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsValid",
                table: "Universities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsValid",
                table: "Universities");
        }
    }
}
