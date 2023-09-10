using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NenWebApp.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c8befe38-996e-4043-97b8-6dca96399de1"));

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "IsPublic", "Name", "Notes", "PrimaryMuscle", "Region", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("0baf325b-b8b1-4221-810e-2d5da10b7d09"), false, "Cable Chest Press (Lower)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("1b944596-707e-4f8b-8e45-63e9a80fa7a7"), false, "Leg Curl", "This is a default exericse", "Hamstring", "Lower", "Strength", null },
                    { new Guid("1f5dd2d0-5d7c-4c14-9a87-7a687acd2d27"), false, "Decline Dumbell Curl", "This is a default exericse", "Bicep", "Upper", "Strength", null },
                    { new Guid("21e53bc1-114f-4721-927a-7b4a06ea4ab9"), false, "Dumbell Bench Press", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("2bada102-9f26-4e25-8347-f5624b3c6ecb"), false, "High Row", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("316d16db-6dcd-49bc-8473-7c6db56ae48c"), false, "Butterfly Curl", "This is a default exericse", "Hamstring", "Lower", "Strength", null },
                    { new Guid("384a3a86-a017-4441-99fb-aff9c9bd2850"), false, "Cable Row (Upper Back)", "This is a default exericse", "UpperBack", "Upper", "Strength", null },
                    { new Guid("40f1c44d-ee0d-4823-bafa-05d9e0589e33"), false, "Hip Adduction", "This is a default exericse", "Hip", "Lower", "Mobility", null },
                    { new Guid("5a80275a-6eb8-4f56-a1fe-fa6209c7ab2c"), false, "Push Up", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("5ed4928a-1dc2-4044-ada2-90afa6f6a6b6"), false, "Pulldown (Upper Back)", "This is a default exericse", "UpperBack", "Upper", "Strength", null },
                    { new Guid("75b6a711-e6f3-43a5-82b3-64abdeaa8179"), false, "Leg Press", "This is a default exericse", "Quad", "Lower", "Strength", null },
                    { new Guid("7a81b7f0-dd70-4946-86cb-754e923ad5df"), false, "Pike Pushup", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("83256f42-331b-45c0-8de3-fe9666e97a44"), false, "Handstand", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("86e24576-03d4-418f-b8e5-4bc1936a13a6"), false, "Wrist Curl", "This is a default exericse", "Forearm", "Upper", "Strength", null },
                    { new Guid("8831f8d0-0814-4571-9b39-28c79c123f7d"), false, "Incline Dumbell Curl", "This is a default exericse", "Bicep", "Upper", "Strength", null },
                    { new Guid("8c6bbf80-f258-4417-82d4-b60854af88db"), false, "Overhead Press", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("91a1dc23-8355-4787-8988-2a5e39efcfe2"), false, "Handstand Pushup", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("a500ca81-5b2e-48e2-a784-24563216e1b1"), false, "Dip (Forearms)", "This is a default exericse", "Forearm", "Upper", "Strength", null },
                    { new Guid("b45ea12e-988e-4f49-a486-ef3fb7ed5bde"), false, "Cable Row (Lats)", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("ba9345c2-74ca-4c93-ba99-8e2af32adb38"), false, "Dip (Chest)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("bdf7f79c-8be4-42ba-ae94-c259559fdb65"), false, "Hip Abduction", "This is a default exericse", "Hip", "Lower", "Mobility", null },
                    { new Guid("c5059951-565e-48f9-b4f2-be6c55c03b73"), false, "Cable Chest Press (Upper)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("c8ea79cd-2030-4fa4-b821-d4677aa4acda"), false, "Lu Raise", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("e39df392-3344-4eb0-86ef-2646fe3639f6"), false, "Cable Chest Press (Middle)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("e8463e56-4769-445b-bcf2-37a08d2fb5ac"), false, "Tricep Pushdown", "This is a default exericse", "Tricep", "Upper", "Strength", null },
                    { new Guid("edfa6b5b-3a96-451c-b1e4-a459fb828612"), false, "45 Degree Hyperextension", "This is a default exericse", "Glutes", "Lower", "Strength", null },
                    { new Guid("f09fccb1-037f-43c1-8d8a-704900d0eeb5"), false, "Barbell Bench Press", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("f106b141-bc18-4758-8265-d082ca46ca5f"), false, "Pull Up", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("f7388a00-e329-444d-9834-bc0167f3c1e1"), false, "Lat Pulldown", "This is a default exericse", "Lat", "Upper", "Strength", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0baf325b-b8b1-4221-810e-2d5da10b7d09"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1b944596-707e-4f8b-8e45-63e9a80fa7a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1f5dd2d0-5d7c-4c14-9a87-7a687acd2d27"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("21e53bc1-114f-4721-927a-7b4a06ea4ab9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2bada102-9f26-4e25-8347-f5624b3c6ecb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("316d16db-6dcd-49bc-8473-7c6db56ae48c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("384a3a86-a017-4441-99fb-aff9c9bd2850"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("40f1c44d-ee0d-4823-bafa-05d9e0589e33"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5a80275a-6eb8-4f56-a1fe-fa6209c7ab2c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5ed4928a-1dc2-4044-ada2-90afa6f6a6b6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("75b6a711-e6f3-43a5-82b3-64abdeaa8179"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7a81b7f0-dd70-4946-86cb-754e923ad5df"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("83256f42-331b-45c0-8de3-fe9666e97a44"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86e24576-03d4-418f-b8e5-4bc1936a13a6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8831f8d0-0814-4571-9b39-28c79c123f7d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8c6bbf80-f258-4417-82d4-b60854af88db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("91a1dc23-8355-4787-8988-2a5e39efcfe2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a500ca81-5b2e-48e2-a784-24563216e1b1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b45ea12e-988e-4f49-a486-ef3fb7ed5bde"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ba9345c2-74ca-4c93-ba99-8e2af32adb38"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bdf7f79c-8be4-42ba-ae94-c259559fdb65"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5059951-565e-48f9-b4f2-be6c55c03b73"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c8ea79cd-2030-4fa4-b821-d4677aa4acda"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e39df392-3344-4eb0-86ef-2646fe3639f6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e8463e56-4769-445b-bcf2-37a08d2fb5ac"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("edfa6b5b-3a96-451c-b1e4-a459fb828612"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f09fccb1-037f-43c1-8d8a-704900d0eeb5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f106b141-bc18-4758-8265-d082ca46ca5f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f7388a00-e329-444d-9834-bc0167f3c1e1"));

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "IsPublic", "Name", "Notes", "PrimaryMuscle", "Region", "Type", "UserId" },
                values: new object[] { new Guid("c8befe38-996e-4043-97b8-6dca96399de1"), false, "Pull Up", "This is a default exericse", "Lat", "Upper", "Strength", null });
        }
    }
}
