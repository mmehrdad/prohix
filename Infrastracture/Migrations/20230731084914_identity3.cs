using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prohix.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class identity3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("74140121-7bb1-4079-90e5-85cc90f443aa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a0f1aae2-f987-41bd-a9f3-2c2cb78fecb9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d84cd155-702c-4e41-85ba-1e5a1e446e9f"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0c8ea191-8661-4d56-a33d-734bf94530ce"), null, "Student", "STUDENT" },
                    { new Guid("119409de-9251-47f2-8986-398296fe0546"), null, "Teacher", "TEACHER" },
                    { new Guid("965450f7-7798-4466-9f38-804b18e64157"), null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("74140121-7bb1-4079-90e5-85cc90f443aa"), null, "Teacher", null },
                    { new Guid("a0f1aae2-f987-41bd-a9f3-2c2cb78fecb9"), null, "Student", null },
                    { new Guid("d84cd155-702c-4e41-85ba-1e5a1e446e9f"), null, "Admin", null }
                });
        }
    }
}
