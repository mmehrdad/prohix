using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prohix.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class studentscond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Countries_SecoundCitizenshipId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SecoundCitizenshipId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "SureName",
                table: "Students",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "SecoundCitizenshipId",
                table: "Students",
                newName: "SecondCitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SecondCitizenshipId",
                table: "Students",
                column: "SecondCitizenshipId",
                unique: true,
                filter: "[SecondCitizenshipId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Countries_SecondCitizenshipId",
                table: "Students",
                column: "SecondCitizenshipId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Countries_SecondCitizenshipId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SecondCitizenshipId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Students",
                newName: "SureName");

            migrationBuilder.RenameColumn(
                name: "SecondCitizenshipId",
                table: "Students",
                newName: "SecoundCitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SecoundCitizenshipId",
                table: "Students",
                column: "SecoundCitizenshipId",
                unique: true,
                filter: "[SecoundCitizenshipId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Countries_SecoundCitizenshipId",
                table: "Students",
                column: "SecoundCitizenshipId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
