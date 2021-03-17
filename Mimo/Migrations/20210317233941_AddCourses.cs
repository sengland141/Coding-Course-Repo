using Microsoft.EntityFrameworkCore.Migrations;

namespace Mimo.Migrations
{
    public partial class AddCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { 1, "Swift" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { 2, "Javascript" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName" },
                values: new object[] { 3, "C#" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
