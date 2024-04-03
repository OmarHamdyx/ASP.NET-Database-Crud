using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseApi.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "NationalityId", "NationalityName" },
                values: new object[,]
                {
                    { 7722111, "Saudi" },
                    { 8822111, "Egyptian" },
                    { 9922111, "Indian" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Age", "BirthDate", "Name", "NationalityId" },
                values: new object[,]
                {
                    { 111, 28f, new DateTime(1996, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naveen", 9922111 },
                    { 222, 30f, new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Umar", 8822111 },
                    { 333, 32f, new DateTime(1992, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qasem", 7722111 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 7722111);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 8822111);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 9922111);
        }
    }
}
