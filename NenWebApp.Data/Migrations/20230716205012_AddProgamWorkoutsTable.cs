using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NenWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddProgamWorkoutsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_AspNetUsers_ApplicationUserId",
                table: "Workouts");

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

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Workouts");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Workouts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Workouts_ApplicationUserId",
                table: "Workouts",
                newName: "IX_Workouts_UserId");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDaysPerWeek",
                table: "Programs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProgramWorkouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkoutProgramId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramWorkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramWorkouts_Programs_WorkoutProgramId",
                        column: x => x.WorkoutProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProgramWorkouts_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "IsPublic", "Name", "Notes", "PrimaryMuscle", "Region", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("02770326-ba92-4c40-b170-efb23d466e3c"), false, "Pulldown (Upper Back)", "This is a default exericse", "UpperBack", "Upper", "Strength", null },
                    { new Guid("036ff2c4-aac0-4049-b945-cf50cc08f506"), false, "Dumbell Bench Press", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("03ba56df-38c1-4e22-a858-47448bfa760d"), false, "Cable Row (Lats)", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("0bebf9c1-bc9f-4bcc-b22e-e8b39ee1d83e"), false, "Dip (Forearms)", "This is a default exericse", "Forearm", "Upper", "Strength", null },
                    { new Guid("225d005b-165c-499d-845b-8a89ca119fd7"), false, "Cable Chest Press (Lower)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("24adb61d-f561-4a53-9b21-10dd54aeaccb"), false, "Barbell Bench Press", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("2b84470a-6337-42cf-8feb-e1ea67d5df3e"), false, "Tricep Pushdown", "This is a default exericse", "Tricep", "Upper", "Strength", null },
                    { new Guid("3c156a82-4725-4684-9c24-c73bfd6da4c0"), false, "Hip Adduction", "This is a default exericse", "Hip", "Lower", "Mobility", null },
                    { new Guid("6ec383f5-8161-4706-a0d3-5af6f9f5f75c"), false, "Leg Curl", "This is a default exericse", "Hamstring", "Lower", "Strength", null },
                    { new Guid("6f50f6ac-080a-446b-a94d-bc722cb61c91"), false, "Handstand Pushup", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("71b2ddf0-764b-4205-be57-276cbbde2ec6"), false, "Pike Pushup", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("77781f4c-5a13-48ca-a502-bb19a111b145"), false, "45 Degree Hyperextension", "This is a default exericse", "Glutes", "Lower", "Strength", null },
                    { new Guid("77e52512-626c-4f0a-8396-a69047382a00"), false, "High Row", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("8001ee4b-0ff2-4849-bedf-b06493cb1a89"), false, "Leg Press", "This is a default exericse", "Quad", "Lower", "Strength", null },
                    { new Guid("841ed2a4-6f9a-4a42-9b92-6f4ae71b5272"), false, "Decline Dumbell Curl", "This is a default exericse", "Bicep", "Upper", "Strength", null },
                    { new Guid("8abd1ae2-81cd-4d05-aabc-70fbff7eb815"), false, "Hip Abduction", "This is a default exericse", "Hip", "Lower", "Mobility", null },
                    { new Guid("9baa772a-0b1b-4497-b165-b85130a0079a"), false, "Cable Chest Press (Upper)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("a25656b6-859c-45af-a993-bf7fea091fa4"), false, "Wrist Curl", "This is a default exericse", "Forearm", "Upper", "Strength", null },
                    { new Guid("a40bb57d-b59b-4b5c-801c-96e53ba66d75"), false, "Pull Up", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("a5f17443-3ed8-453b-8f34-bfc253ce2e78"), false, "Lu Raise", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("ac323a94-056c-45db-a6c4-b7dd158312e5"), false, "Dip (Chest)", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("b941823f-35e4-4b21-8163-778636306443"), false, "Butterfly Curl", "This is a default exericse", "Hamstring", "Lower", "Strength", null },
                    { new Guid("ca4df0c7-29eb-4889-923c-f5825f6d1744"), false, "Push Up", "This is a default exericse", "Chest", "Upper", "Strength", null },
                    { new Guid("cd8ba27c-dea7-48d9-ba4d-61600e14b275"), false, "Lat Pulldown", "This is a default exericse", "Lat", "Upper", "Strength", null },
                    { new Guid("da84c7f6-9c77-4d23-8ce8-82ff7be83862"), false, "Incline Dumbell Curl", "This is a default exericse", "Bicep", "Upper", "Strength", null },
                    { new Guid("dd0f6c20-5f08-43f4-bd62-7a75b8be9216"), false, "Handstand", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("e464a9c8-5d0b-4eda-9dd8-afc0d3932c67"), false, "Overhead Press", "This is a default exericse", "Shoulder", "Upper", "Strength", null },
                    { new Guid("ebe091e8-7741-41fd-8237-ab2ef1ef739b"), false, "Cable Row (Upper Back)", "This is a default exericse", "UpperBack", "Upper", "Strength", null },
                    { new Guid("fb60e558-adcc-49c6-b23f-b82540b148b8"), false, "Cable Chest Press (Middle)", "This is a default exericse", "Chest", "Upper", "Strength", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramWorkouts_WorkoutId",
                table: "ProgramWorkouts",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramWorkouts_WorkoutProgramId",
                table: "ProgramWorkouts",
                column: "WorkoutProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_AspNetUsers_UserId",
                table: "Workouts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_AspNetUsers_UserId",
                table: "Workouts");

            migrationBuilder.DropTable(
                name: "ProgramWorkouts");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("02770326-ba92-4c40-b170-efb23d466e3c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("036ff2c4-aac0-4049-b945-cf50cc08f506"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("03ba56df-38c1-4e22-a858-47448bfa760d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0bebf9c1-bc9f-4bcc-b22e-e8b39ee1d83e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("225d005b-165c-499d-845b-8a89ca119fd7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("24adb61d-f561-4a53-9b21-10dd54aeaccb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2b84470a-6337-42cf-8feb-e1ea67d5df3e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3c156a82-4725-4684-9c24-c73bfd6da4c0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6ec383f5-8161-4706-a0d3-5af6f9f5f75c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6f50f6ac-080a-446b-a94d-bc722cb61c91"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("71b2ddf0-764b-4205-be57-276cbbde2ec6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77781f4c-5a13-48ca-a502-bb19a111b145"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("77e52512-626c-4f0a-8396-a69047382a00"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8001ee4b-0ff2-4849-bedf-b06493cb1a89"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("841ed2a4-6f9a-4a42-9b92-6f4ae71b5272"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8abd1ae2-81cd-4d05-aabc-70fbff7eb815"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9baa772a-0b1b-4497-b165-b85130a0079a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a25656b6-859c-45af-a993-bf7fea091fa4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a40bb57d-b59b-4b5c-801c-96e53ba66d75"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a5f17443-3ed8-453b-8f34-bfc253ce2e78"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ac323a94-056c-45db-a6c4-b7dd158312e5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b941823f-35e4-4b21-8163-778636306443"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ca4df0c7-29eb-4889-923c-f5825f6d1744"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cd8ba27c-dea7-48d9-ba4d-61600e14b275"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("da84c7f6-9c77-4d23-8ce8-82ff7be83862"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dd0f6c20-5f08-43f4-bd62-7a75b8be9216"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e464a9c8-5d0b-4eda-9dd8-afc0d3932c67"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ebe091e8-7741-41fd-8237-ab2ef1ef739b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fb60e558-adcc-49c6-b23f-b82540b148b8"));

            migrationBuilder.DropColumn(
                name: "NumberOfDaysPerWeek",
                table: "Programs");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Workouts",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Workouts_UserId",
                table: "Workouts",
                newName: "IX_Workouts_ApplicationUserId");

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "FK_Workouts_AspNetUsers_ApplicationUserId",
                table: "Workouts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
