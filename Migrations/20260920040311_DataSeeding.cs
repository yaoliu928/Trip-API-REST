using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trip.API.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Description", "DiscountPercent", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"), new DateTime(2026, 9, 20, 0, 0, 0, 0, DateTimeKind.Utc), null, "This is a sample description for the tourist route.", null, null, null, null, 0m, "test title", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("6f9619ff-8b86-d011-b42d-00c04fc964ff"));
        }
    }
}
