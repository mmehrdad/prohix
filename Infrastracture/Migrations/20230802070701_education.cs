using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prohix.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class education : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Countries_CountryId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_CountryId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_FieldOfStudyId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_GradeOfStudyId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_UniversityId",
                table: "Educations");

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

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CountryId",
                table: "Educations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_FieldOfStudyId",
                table: "Educations",
                column: "FieldOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_GradeOfStudyId",
                table: "Educations",
                column: "GradeOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UniversityId",
                table: "Educations",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Countries_CountryId",
                table: "Educations",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Countries_CountryId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_CountryId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_FieldOfStudyId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_GradeOfStudyId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_UniversityId",
                table: "Educations");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3bd7fabb-1e00-42b3-b709-827cb34d5963"), null, "Teacher", "TEACHER" },
                    { new Guid("81857a91-4bcd-489b-86e1-0c2645947029"), null, "Student", "STUDENT" },
                    { new Guid("de6c649b-a2e5-4ff3-9354-107850277c78"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CountryId",
                table: "Educations",
                column: "CountryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_FieldOfStudyId",
                table: "Educations",
                column: "FieldOfStudyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_GradeOfStudyId",
                table: "Educations",
                column: "GradeOfStudyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UniversityId",
                table: "Educations",
                column: "UniversityId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Countries_CountryId",
                table: "Educations",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
