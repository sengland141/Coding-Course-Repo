using Microsoft.EntityFrameworkCore.Migrations;

namespace Mimo.Migrations
{
    public partial class AddOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Lessons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Chapters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "Order",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "Order",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Order",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                column: "Order",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                column: "Order",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                column: "Order",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Order",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Order",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Order",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Order",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Order",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Order",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Chapters");
        }
    }
}
