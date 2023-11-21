using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prohix.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class teacherscond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SureName",
                table: "Teachers",
                newName: "Surname");

            migrationBuilder.AddColumn<byte>(
                name: "Gender",
                table: "Teachers",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Teachers",
                newName: "SureName");
        }
    }
}
