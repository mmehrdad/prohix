using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prohix.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class university : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Universities_Countries_CountryId",
                table: "Universities");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0c8ea191-8661-4d56-a33d-734bf94530ce"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("119409de-9251-47f2-8986-398296fe0546"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("965450f7-7798-4466-9f38-804b18e64157"));

            migrationBuilder.AlterColumn<long>(
                name: "CountryId",
                table: "Universities",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3bd7fabb-1e00-42b3-b709-827cb34d5963"), null, "Teacher", "TEACHER" },
                    { new Guid("81857a91-4bcd-489b-86e1-0c2645947029"), null, "Student", "STUDENT" },
                    { new Guid("de6c649b-a2e5-4ff3-9354-107850277c78"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_Countries_CountryId",
                table: "Universities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Universities_Countries_CountryId",
                table: "Universities");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3bd7fabb-1e00-42b3-b709-827cb34d5963"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("81857a91-4bcd-489b-86e1-0c2645947029"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("de6c649b-a2e5-4ff3-9354-107850277c78"));

            migrationBuilder.AlterColumn<long>(
                name: "CountryId",
                table: "Universities",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0c8ea191-8661-4d56-a33d-734bf94530ce"), null, "Student", "STUDENT" },
                    { new Guid("119409de-9251-47f2-8986-398296fe0546"), null, "Teacher", "TEACHER" },
                    { new Guid("965450f7-7798-4466-9f38-804b18e64157"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Universities_Countries_CountryId",
                table: "Universities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
