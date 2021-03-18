using Microsoft.EntityFrameworkCore.Migrations;

namespace Mimo.Migrations
{
    public partial class PopulateAchievementTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AchievementTypes",
                columns: new[] { "Id", "AchievementTypeName" },
                values: new object[] { 1, "LessonCount" });

            migrationBuilder.InsertData(
                table: "AchievementTypes",
                columns: new[] { "Id", "AchievementTypeName" },
                values: new object[] { 2, "ChapterCount" });

            migrationBuilder.InsertData(
                table: "AchievementTypes",
                columns: new[] { "Id", "AchievementTypeName" },
                values: new object[] { 3, "CompleteSwiftCourse" });

            migrationBuilder.InsertData(
                table: "AchievementTypes",
                columns: new[] { "Id", "AchievementTypeName" },
                values: new object[] { 4, "CompleteJavascriptCourse" });

            migrationBuilder.InsertData(
                table: "AchievementTypes",
                columns: new[] { "Id", "AchievementTypeName" },
                values: new object[] { 5, "CompleteCSharpCourse" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AchievementTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AchievementTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AchievementTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AchievementTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AchievementTypes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
