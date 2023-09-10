using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NenWebApp.Migrations
{
    /// <inheritdoc />
    public partial class RenameSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sets_DetailedExercises_ExerciseId",
                table: "Sets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sets",
                table: "Sets");

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

            migrationBuilder.RenameTable(
                name: "Sets",
                newName: "ExerciseSets");

            migrationBuilder.RenameIndex(
                name: "IX_Sets_ExerciseId",
                table: "ExerciseSets",
                newName: "IX_ExerciseSets_ExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseSets",
                table: "ExerciseSets",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "IsPublic", "Name", "Notes", "PrimaryMuscle", "Region", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dcfb953-e00d-4d33-a81a-8b313727b9da"), false, "High Row", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("0e508597-1c09-49c7-ba74-41ea48985cca"), false, "Push Up", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("0f0c5090-7ea8-4f8b-b4b8-09d38d2e77c5"), false, "Cable Chest Press (Upper)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("0fed9981-bcfa-4fdb-b522-3b4c4643ca98"), false, "Dumbell Bench Press", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("149bf058-f078-4bd0-a60a-c57a63c0767c"), false, "Butterfly Curl", "This is a default exericse", "Hamstring", "Lower", "Strength", null },
                    { new Guid("1c19c41b-2a63-4d85-908f-b72962425e46"), false, "Pike Pushup", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("227df58b-927f-427f-9499-2f886b11a147"), false, "Lat Pulldown", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("25ff5ea3-2cc2-4131-b3b6-a31171799c9c"), false, "Pull Up", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("294c62d8-f551-48b9-8c96-7a9ab1768986"), false, "Wrist Curl", "This is a default exericse", "Forearm", "Upper", "Strength", null },
                    { new Guid("346d96f2-81df-4ae5-b36c-67d7fe39de72"), false, "Barbell Bench Press", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("399e2534-2121-4ea3-a223-78ef8e9d4a42"), false, "Handstand", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("5bd1b0d2-3f89-4f0c-83c7-adba1d76cb67"), false, "Overhead Press", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("69cbaebe-df3b-480c-b1bc-3b0cf701e7b1"), false, "Hip Abduction", "This is a default exericse", "Hip", "Lower", "Mobility", null },
                    { new Guid("7293d69b-ebef-4f63-8051-39922db86123"), false, "Lu Raise", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("7465724a-e4e8-4804-bd4e-bc02ca0df263"), false, "Handstand Pushup", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("7aafb241-3b90-4ffd-837b-4801e398008e"), false, "Tricep Pushdown", "This is a default exericse", "Tricep", "Upper", "Strength", null },
                    { new Guid("80dda7bd-64cb-466e-b6c7-4096192d7326"), false, "Leg Curl", "This is a default exericse", "Hamstring", "Lower", "Strength", null },
                    { new Guid("9cd74a2b-bf27-43c5-8409-9f85f73a9d94"), false, "Decline Dumbell Curl", "This is a default exericse", "Bicep", "Upper", "Strength", null },
                    { new Guid("b111bdb8-bdad-45fc-916f-ee058ab63a52"), false, "45 Degree Hyperextension", "This is a default exericse", "Glutes", "Lower", "Strength", null },
                    { new Guid("b1ffec69-d67a-4af9-9991-1e36d9dff06e"), false, "Incline Dumbell Curl", "This is a default exericse", "Bicep", "Upper", "Strength", null },
                    { new Guid("b2849f0d-507a-4ded-909e-a86dadcffce6"), false, "Hip Adduction", "This is a default exericse", "Hip", "Lower", "Mobility", null },
                    { new Guid("b48773ff-92f2-4ea2-837a-0c753a11c643"), false, "Dip (Forearms)", "This is a default exericse", "Forearm", "Upper", "Strength", null },
                    { new Guid("b7b2243c-ddb4-486a-b188-2bd0df9b68ee"), false, "Leg Press", "This is a default exericse", "Quad", "Lower", "Strength", null },
                    { new Guid("b8c4058e-8d7a-449a-86b2-73ff12be2e02"), false, "Cable Chest Press (Lower)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("d8d2faf0-6575-4d8a-bf8e-011b74c893f9"), false, "Pulldown (Upper Back)", "This is a default exericse", "UpperBack", "Upper", "Strength", null },
                    { new Guid("de08bff1-9a0a-433d-bb16-e37b871ed35a"), false, "Dip (Chest)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("e440aa2b-1276-46d0-9475-1a111c4369b8"), false, "Cable Chest Press (Middle)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("f59d5a83-3925-48b9-a90c-d649be7871b4"), false, "Cable Row (Upper Back)", "This is a default exericse", "UpperBack", "Upper", "Strength", null },
                    { new Guid("f8a8cf52-7b5b-4dd6-9c78-b2578f96bb3d"), false, "Cable Row (Lats)", "This is a default exericse", "Lat", "Upper", "Strength", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseSets_DetailedExercises_ExerciseId",
                table: "ExerciseSets",
                column: "ExerciseId",
                principalTable: "DetailedExercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseSets_DetailedExercises_ExerciseId",
                table: "ExerciseSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseSets",
                table: "ExerciseSets");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0dcfb953-e00d-4d33-a81a-8b313727b9da"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0e508597-1c09-49c7-ba74-41ea48985cca"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0f0c5090-7ea8-4f8b-b4b8-09d38d2e77c5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0fed9981-bcfa-4fdb-b522-3b4c4643ca98"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("149bf058-f078-4bd0-a60a-c57a63c0767c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1c19c41b-2a63-4d85-908f-b72962425e46"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("227df58b-927f-427f-9499-2f886b11a147"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("25ff5ea3-2cc2-4131-b3b6-a31171799c9c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("294c62d8-f551-48b9-8c96-7a9ab1768986"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("346d96f2-81df-4ae5-b36c-67d7fe39de72"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("399e2534-2121-4ea3-a223-78ef8e9d4a42"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5bd1b0d2-3f89-4f0c-83c7-adba1d76cb67"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("69cbaebe-df3b-480c-b1bc-3b0cf701e7b1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7293d69b-ebef-4f63-8051-39922db86123"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7465724a-e4e8-4804-bd4e-bc02ca0df263"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7aafb241-3b90-4ffd-837b-4801e398008e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("80dda7bd-64cb-466e-b6c7-4096192d7326"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9cd74a2b-bf27-43c5-8409-9f85f73a9d94"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b111bdb8-bdad-45fc-916f-ee058ab63a52"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b1ffec69-d67a-4af9-9991-1e36d9dff06e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b2849f0d-507a-4ded-909e-a86dadcffce6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b48773ff-92f2-4ea2-837a-0c753a11c643"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b7b2243c-ddb4-486a-b188-2bd0df9b68ee"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b8c4058e-8d7a-449a-86b2-73ff12be2e02"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d8d2faf0-6575-4d8a-bf8e-011b74c893f9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("de08bff1-9a0a-433d-bb16-e37b871ed35a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e440aa2b-1276-46d0-9475-1a111c4369b8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f59d5a83-3925-48b9-a90c-d649be7871b4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f8a8cf52-7b5b-4dd6-9c78-b2578f96bb3d"));

            migrationBuilder.RenameTable(
                name: "ExerciseSets",
                newName: "Sets");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseSets_ExerciseId",
                table: "Sets",
                newName: "IX_Sets_ExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sets",
                table: "Sets",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_DetailedExercises_ExerciseId",
                table: "Sets",
                column: "ExerciseId",
                principalTable: "DetailedExercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
