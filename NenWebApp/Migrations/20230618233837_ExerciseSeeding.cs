using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NenWebApp.Migrations
{
    /// <inheritdoc />
    public partial class ExerciseSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "IsPublic", "Name", "Notes", "PrimaryMuscle", "Region", "Type", "UserId" },
                values: new object[] { new Guid("c8befe38-996e-4043-97b8-6dca96399de1"), false, "Pull Up", "This is a default exericse", "Lat", "Upper", "Strength", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c8befe38-996e-4043-97b8-6dca96399de1"));
        }
    }
}
