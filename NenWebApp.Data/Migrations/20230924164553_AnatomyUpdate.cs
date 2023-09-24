using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NenWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AnatomyUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "PrimaryMuscle",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Exercises");

            migrationBuilder.AddColumn<Guid>(
                name: "AnatomyId",
                table: "Exercises",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Anatomies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    BodyPart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anatomies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Anatomies",
                columns: new[] { "Id", "BodyPart", "Category", "Name", "Section" },
                values: new object[,]
                {
                    { new Guid("18892b23-81ef-4d9e-b932-726c83ee64f8"), 0, 0, "Rectus Abdominis", 0 },
                    { new Guid("1c084135-fcb1-4964-93e9-d2bde95014da"), 3, 0, "Shoulder", 0 },
                    { new Guid("2a575781-4d10-45d0-9416-17771d7c6995"), 2, 2, "Tibialis", 0 },
                    { new Guid("3622ef3b-7bf1-4d66-8800-94577f9224ca"), 2, 1, "Ankle", 0 },
                    { new Guid("38ea258c-7df3-4a24-ad1a-138a599ed605"), 3, 0, "Bicep", 0 },
                    { new Guid("3cc7f935-035b-4722-bcc2-130363295b3d"), 0, 0, "Lower Back", 0 },
                    { new Guid("437d5ef7-30a7-4dcf-927f-8d96f72ed913"), 2, 0, "Glute", 0 },
                    { new Guid("5337d77e-2cd1-414f-82c6-dccfea529633"), 0, 0, "Abdominal Oblique", 0 },
                    { new Guid("64a099c8-702f-4d6f-af79-a8922ebb033f"), 3, 0, "Tricep", 0 },
                    { new Guid("882b1801-669d-4446-825e-38bd760789a7"), 2, 0, "Quad", 0 },
                    { new Guid("973d9b22-552b-4cc0-9a9d-25553cdb91a3"), 2, 0, "Hamstring", 0 },
                    { new Guid("b3563503-ef0f-4101-a535-6b833c1046bc"), 2, 0, "Calf", 0 },
                    { new Guid("c809042b-6eb5-4241-bd7f-22caf7507191"), 3, 0, "Forearm", 0 },
                    { new Guid("d1171602-cf49-4cc7-9a5f-c45ba6695762"), 2, 1, "Hip", 0 },
                    { new Guid("e0af27d6-9a02-4ec5-a2ed-cb2550816b93"), 0, 0, "Chest", 0 },
                    { new Guid("e67fabbc-6edd-4605-baef-363500fafb79"), 0, 0, "Upper Back", 0 },
                    { new Guid("f9152edf-de00-4f4f-ba8a-258aeccb6a36"), 3, 1, "Wrist", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_AnatomyId",
                table: "Exercises",
                column: "AnatomyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Anatomies_AnatomyId",
                table: "Exercises",
                column: "AnatomyId",
                principalTable: "Anatomies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Anatomies_AnatomyId",
                table: "Exercises");

            migrationBuilder.DropTable(
                name: "Anatomies");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_AnatomyId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "AnatomyId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Exercises");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryMuscle",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
        }
    }
}
