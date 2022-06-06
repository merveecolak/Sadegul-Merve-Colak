using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KURS.DATA.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthDay", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ayse", "Naz" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthDay", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Merve", "Usul" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthDay", "FirstName", "LastName" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Can", "Zeki" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthDay", "FirstName", "LastName" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ali", "Daglı" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);
        }
    }
}
