using Microsoft.EntityFrameworkCore.Migrations;

namespace Mimo.Migrations
{
    public partial class PopulateAchievementData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AchievementTypeId", "Description", "RequiredCount" },
                values: new object[] { 1, 1, "Complete 5 lessons", 5 });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AchievementTypeId", "Description", "RequiredCount" },
                values: new object[] { 2, 1, "Complete 25 lessons", 25 });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AchievementTypeId", "Description", "RequiredCount" },
                values: new object[] { 3, 1, "Complete 50 lessons", 50 });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AchievementTypeId", "Description", "RequiredCount" },
                values: new object[] { 4, 2, "Complete 1 chapter", 1 });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AchievementTypeId", "Description", "RequiredCount" },
                values: new object[] { 5, 2, "Complete 5 chapters", 5 });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AchievementTypeId", "Description", "RequiredCount" },
                values: new object[] { 6, 3, "Complete the Swift course", 1 });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AchievementTypeId", "Description", "RequiredCount" },
                values: new object[] { 7, 4, "Complete the Javascript course", 1 });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "AchievementTypeId", "Description", "RequiredCount" },
                values: new object[] { 8, 5, "Complete the C# course", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
