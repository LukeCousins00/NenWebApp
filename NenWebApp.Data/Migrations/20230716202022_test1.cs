using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NenWebApp.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("03366e72-c705-4c39-a0c6-50618988f72e"), false, "Leg Press", "This is a default exericse", "Quad", "Lower", "Strength", null },
                    { new Guid("0e63ccec-85f2-4fcc-84eb-3000ab9b8e9d"), false, "Handstand", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("1f55df94-8fee-4e90-87d9-92055cce0a04"), false, "Leg Curl", "This is a default exericse", "Hamstring", "Lower", "Strength", null },
                    { new Guid("20651e97-8b9c-4b83-bea2-8ea71eac4f4d"), false, "Tricep Pushdown", "This is a default exericse", "Tricep", "Upper", "Strength", null },
                    { new Guid("254b3ab8-f483-4682-992e-2fc5745d7743"), false, "Handstand Pushup", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("3440ac15-0250-4926-b4c1-ea2711297dfc"), false, "Cable Chest Press (Upper)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("3cbc6d24-6c81-4304-b474-8f547807b215"), false, "Hip Abduction", "This is a default exericse", "Hip", "Lower", "Mobility", null },
                    { new Guid("4a4df294-996d-4164-85c9-3e869f09739f"), false, "Cable Row (Upper Back)", "This is a default exericse", "UpperBack", "Upper", "Strength", null },
                    { new Guid("5b4e6c44-350e-4df0-b508-9a9efbdf314c"), false, "45 Degree Hyperextension", "This is a default exericse", "Glutes", "Lower", "Strength", null },
                    { new Guid("65964d5c-75d2-447f-ac75-f3ca096e7e11"), false, "Hip Adduction", "This is a default exericse", "Hip", "Lower", "Mobility", null },
                    { new Guid("662e9141-ea13-4180-aa9d-ea738f036630"), false, "Lu Raise", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("772dc1c2-954e-4493-80aa-9836f3855cb3"), false, "Pike Pushup", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("790889a4-da20-4e75-b492-80c085a0a5c2"), false, "Lat Pulldown", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("790c2558-08f7-4264-b05e-6a3ae249cd2d"), false, "Barbell Bench Press", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("7a35bb6d-0be1-46fa-83ad-2bece8fb01f8"), false, "Wrist Curl", "This is a default exericse", "Forearm", "Upper", "Strength", null },
                    { new Guid("8a7017ac-d861-4c1c-a5c8-f220fab42df6"), false, "Cable Chest Press (Lower)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("8bbdb320-01a6-485e-8da1-0a9171c2b9a1"), false, "High Row", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("94357de4-12c3-46b8-b30c-eb8b5d65ff0d"), false, "Incline Dumbell Curl", "This is a default exericse", "Bicep", "Upper", "Strength", null },
                    { new Guid("9dd3a01a-39ae-4cd2-90db-2c2b8b4e6ab1"), false, "Dumbell Bench Press", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("ad5158b3-3d46-4b5c-a07a-e8ce6b323991"), false, "Dip (Chest)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("beaa4976-ba84-4bcf-94a8-9b3fb533779a"), false, "Decline Dumbell Curl", "This is a default exericse", "Bicep", "Upper", "Strength", null },
                    { new Guid("c5b80c2d-dcc3-4a96-8839-e4bfd211e695"), false, "Pulldown (Upper Back)", "This is a default exericse", "UpperBack", "Upper", "Strength", null },
                    { new Guid("c999bc01-7b4f-4fae-85b3-c710ffba5ab2"), false, "Dip (Forearms)", "This is a default exericse", "Forearm", "Upper", "Strength", null },
                    { new Guid("e656073f-6541-45f0-a07f-95303f5c190c"), false, "Cable Chest Press (Middle)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("e7ac27c4-a320-4d26-b31a-4a83e25d1a25"), false, "Overhead Press", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("e8967e13-11fe-4b44-b5e3-2261d5a4b9a7"), false, "Pull Up", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("eb745b0c-603f-4d0c-8854-89f88808df00"), false, "Push Up", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("f55d299c-8887-4205-b74d-0f6b7f4171b6"), false, "Butterfly Curl", "This is a default exericse", "Hamstring", "Lower", "Strength", null },
                    { new Guid("fd61febb-d17e-449e-92a1-d8a1672f4894"), false, "Cable Row (Lats)", "This is a default exericse", "Lat", "Upper", "Strength", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03366e72-c705-4c39-a0c6-50618988f72e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e63ccec-85f2-4fcc-84eb-3000ab9b8e9d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1f55df94-8fee-4e90-87d9-92055cce0a04"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("20651e97-8b9c-4b83-bea2-8ea71eac4f4d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("254b3ab8-f483-4682-992e-2fc5745d7743"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3440ac15-0250-4926-b4c1-ea2711297dfc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3cbc6d24-6c81-4304-b474-8f547807b215"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4a4df294-996d-4164-85c9-3e869f09739f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5b4e6c44-350e-4df0-b508-9a9efbdf314c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("65964d5c-75d2-447f-ac75-f3ca096e7e11"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("662e9141-ea13-4180-aa9d-ea738f036630"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("772dc1c2-954e-4493-80aa-9836f3855cb3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("790889a4-da20-4e75-b492-80c085a0a5c2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("790c2558-08f7-4264-b05e-6a3ae249cd2d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7a35bb6d-0be1-46fa-83ad-2bece8fb01f8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8a7017ac-d861-4c1c-a5c8-f220fab42df6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8bbdb320-01a6-485e-8da1-0a9171c2b9a1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("94357de4-12c3-46b8-b30c-eb8b5d65ff0d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9dd3a01a-39ae-4cd2-90db-2c2b8b4e6ab1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ad5158b3-3d46-4b5c-a07a-e8ce6b323991"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("beaa4976-ba84-4bcf-94a8-9b3fb533779a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5b80c2d-dcc3-4a96-8839-e4bfd211e695"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c999bc01-7b4f-4fae-85b3-c710ffba5ab2"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e656073f-6541-45f0-a07f-95303f5c190c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e7ac27c4-a320-4d26-b31a-4a83e25d1a25"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e8967e13-11fe-4b44-b5e3-2261d5a4b9a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eb745b0c-603f-4d0c-8854-89f88808df00"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f55d299c-8887-4205-b74d-0f6b7f4171b6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fd61febb-d17e-449e-92a1-d8a1672f4894"));

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
    }
}
