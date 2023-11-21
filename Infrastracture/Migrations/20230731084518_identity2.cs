using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prohix.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class identity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8b3158fb-0afa-4708-a8d9-aa24fa19782d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e75bbc2c-c057-4e4e-8301-778e1bc3f5e9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ec46f5f6-7c46-4c69-82de-a6fa5f7bbd42"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRoles");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "UserRoles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8b3158fb-0afa-4708-a8d9-aa24fa19782d"), null, "Teacher", null },
                    { new Guid("e75bbc2c-c057-4e4e-8301-778e1bc3f5e9"), null, "Admin", null },
                    { new Guid("ec46f5f6-7c46-4c69-82de-a6fa5f7bbd42"), null, "Student", null }
                });
        }
    }
}
