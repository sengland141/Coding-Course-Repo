using Microsoft.EntityFrameworkCore.Migrations;

namespace Mimo.Migrations
{
    public partial class AddChaptersAndLessonsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterName", "ChapterPosition", "CourseId" },
                values: new object[] { 1, "Chapter 1", 1, 1 });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterName", "ChapterPosition", "CourseId" },
                values: new object[] { 2, "Chapter 2", 2, 1 });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterName", "ChapterPosition", "CourseId" },
                values: new object[] { 3, "Chapter 1", 1, 2 });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterName", "ChapterPosition", "CourseId" },
                values: new object[] { 4, "Chapter 2", 2, 2 });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterName", "ChapterPosition", "CourseId" },
                values: new object[] { 5, "Chapter 1", 1, 3 });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterName", "ChapterPosition", "CourseId" },
                values: new object[] { 6, "Chapter 2", 2, 3 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition" },
                values: new object[] { 1, 1, "Lesson 1", 1 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition" },
                values: new object[] { 2, 1, "Chapter 2", 2 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition" },
                values: new object[] { 3, 1, "Chapter 3", 3 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition" },
                values: new object[] { 4, 1, "Chapter 4", 4 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition" },
                values: new object[] { 5, 1, "Chapter 5", 5 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "LessonName", "LessonPosition" },
                values: new object[] { 6, 1, "Chapter 6", 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
