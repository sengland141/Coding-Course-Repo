using Microsoft.EntityFrameworkCore.Migrations;

namespace Mimo.Migrations
{
    public partial class ChangeOrderSqlKeywordInChapterAndLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Order",
                table: "Lessons",
                newName: "LessonPosition");

            migrationBuilder.RenameColumn(
                name: "Order",
                table: "Chapters",
                newName: "ChapterPosition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LessonPosition",
                table: "Lessons",
                newName: "Order");

            migrationBuilder.RenameColumn(
                name: "ChapterPosition",
                table: "Chapters",
                newName: "Order");
        }
    }
}
