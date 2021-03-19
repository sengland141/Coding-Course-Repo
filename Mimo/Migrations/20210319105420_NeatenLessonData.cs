using Microsoft.EntityFrameworkCore.Migrations;

namespace Mimo.Migrations
{
    public partial class NeatenLessonData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 2, "Lesson 1", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 2, "Lesson 2", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 3, "Lesson 1", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 3, "Lesson 2", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "ChapterId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "ChapterId",
                value: 4);

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 9, 5, "Lesson 1", 1, 1 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 10, 5, "Lesson 2", 2, 2 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 11, 6, "Lesson 1", 1, 1 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 12, 6, "Lesson 2", 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 1, "Lesson 3", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 1, "Lesson 4", 4, 4 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 1, "Lesson 5", 5, 5 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChapterId", "LessonName", "LessonPosition", "Order" },
                values: new object[] { 1, "Lesson 6", 6, 6 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "ChapterId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "ChapterId",
                value: 2);
        }
    }
}
