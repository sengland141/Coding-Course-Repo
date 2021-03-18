using Microsoft.EntityFrameworkCore.Migrations;

namespace Mimo.Migrations
{
    public partial class AddAchievementTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AchievementTypeId",
                table: "Achievements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequiredCount",
                table: "Achievements",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AchievementTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AchievementTypeName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_AchievementTypeId",
                table: "Achievements",
                column: "AchievementTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_AchievementTypes_AchievementTypeId",
                table: "Achievements",
                column: "AchievementTypeId",
                principalTable: "AchievementTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_AchievementTypes_AchievementTypeId",
                table: "Achievements");

            migrationBuilder.DropTable(
                name: "AchievementTypes");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_AchievementTypeId",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "AchievementTypeId",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "RequiredCount",
                table: "Achievements");
        }
    }
}
