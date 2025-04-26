using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDiaryEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 4, 10, 6, 30, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 4, 12, 14, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 4, 16, 3, 33, 46, 79, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 4, 18, 3, 33, 46, 79, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 3, "Spilled latte on my keyboard; spent the afternoon cleaning switches.", new DateTime(2025, 4, 19, 3, 33, 46, 79, DateTimeKind.Local).AddTicks(7651), "Coffee Mishap" },
                    { 4, "Discovered brutalist websites—love the raw typography.", new DateTime(2025, 4, 20, 3, 33, 46, 79, DateTimeKind.Local).AddTicks(7654), "Design Inspiration" },
                    { 5, "Set up Trello and assigned tasks for the sociology presentation.", new DateTime(2025, 4, 22, 3, 33, 46, 79, DateTimeKind.Local).AddTicks(7656), "Group Project Sync" },
                    { 6, "Practiced persuasive speech; trimmed intro to stay under 7 minutes.", new DateTime(2025, 4, 23, 3, 33, 46, 79, DateTimeKind.Local).AddTicks(7659), "Public-Speaking Rehearsal" },
                    { 7, "Fixed the 500 error—missing header in the POST request.", new DateTime(2025, 4, 24, 3, 33, 46, 79, DateTimeKind.Local).AddTicks(7661), "API Breakthrough" },
                    { 8, "Refactored the diary search feature to use LINQ queries.", new DateTime(2025, 4, 25, 3, 33, 46, 79, DateTimeKind.Local).AddTicks(7663), "Late-Night Coding" },
                    { 9, "Listened to ‘Design Better’ while walking downtown.", new DateTime(2025, 4, 25, 21, 33, 46, 79, DateTimeKind.Local).AddTicks(7666), "Podcast Walk" },
                    { 10, "Demoed new UI to the client—positive feedback on the color palette.", new DateTime(2025, 4, 26, 3, 33, 46, 79, DateTimeKind.Local).AddTicks(7674), "Sprint Review" }
                });
        }
    }
}
