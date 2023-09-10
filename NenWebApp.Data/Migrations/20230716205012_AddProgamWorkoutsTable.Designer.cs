﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NenWebApp.Data;

#nullable disable

namespace NenWebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230716205012_AddProgamWorkoutsTable")]
    partial class AddProgamWorkoutsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.CoverPhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("CoverPhoto");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.DetailedExercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BaseInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("HighReps")
                        .HasColumnType("int");

                    b.Property<int>("LowReps")
                        .HasColumnType("int");

                    b.Property<int>("Rest")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<Guid>("WorkoutId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BaseInformationId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("DetailedExercises");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Notes")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PrimaryMuscle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a40bb57d-b59b-4b5c-801c-96e53ba66d75"),
                            IsPublic = false,
                            Name = "Pull Up",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Lat",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("cd8ba27c-dea7-48d9-ba4d-61600e14b275"),
                            IsPublic = false,
                            Name = "Lat Pulldown",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Lat",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("02770326-ba92-4c40-b170-efb23d466e3c"),
                            IsPublic = false,
                            Name = "Pulldown (Upper Back)",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "UpperBack",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("ca4df0c7-29eb-4889-923c-f5825f6d1744"),
                            IsPublic = false,
                            Name = "Push Up",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Chest",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("8001ee4b-0ff2-4849-bedf-b06493cb1a89"),
                            IsPublic = false,
                            Name = "Leg Press",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Quad",
                            Region = "Lower",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("da84c7f6-9c77-4d23-8ce8-82ff7be83862"),
                            IsPublic = false,
                            Name = "Incline Dumbell Curl",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Bicep",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("841ed2a4-6f9a-4a42-9b92-6f4ae71b5272"),
                            IsPublic = false,
                            Name = "Decline Dumbell Curl",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Bicep",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("ac323a94-056c-45db-a6c4-b7dd158312e5"),
                            IsPublic = false,
                            Name = "Dip (Chest)",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Chest",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("0bebf9c1-bc9f-4bcc-b22e-e8b39ee1d83e"),
                            IsPublic = false,
                            Name = "Dip (Forearms)",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Forearm",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("a25656b6-859c-45af-a993-bf7fea091fa4"),
                            IsPublic = false,
                            Name = "Wrist Curl",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Forearm",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("6ec383f5-8161-4706-a0d3-5af6f9f5f75c"),
                            IsPublic = false,
                            Name = "Leg Curl",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Hamstring",
                            Region = "Lower",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("b941823f-35e4-4b21-8163-778636306443"),
                            IsPublic = false,
                            Name = "Butterfly Curl",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Hamstring",
                            Region = "Lower",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("e464a9c8-5d0b-4eda-9dd8-afc0d3932c67"),
                            IsPublic = false,
                            Name = "Overhead Press",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Shoulder",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("24adb61d-f561-4a53-9b21-10dd54aeaccb"),
                            IsPublic = false,
                            Name = "Barbell Bench Press",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Chest",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("036ff2c4-aac0-4049-b945-cf50cc08f506"),
                            IsPublic = false,
                            Name = "Dumbell Bench Press",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Chest",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("77e52512-626c-4f0a-8396-a69047382a00"),
                            IsPublic = false,
                            Name = "High Row",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Lat",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("77781f4c-5a13-48ca-a502-bb19a111b145"),
                            IsPublic = false,
                            Name = "45 Degree Hyperextension",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Glutes",
                            Region = "Lower",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("2b84470a-6337-42cf-8feb-e1ea67d5df3e"),
                            IsPublic = false,
                            Name = "Tricep Pushdown",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Tricep",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("a5f17443-3ed8-453b-8f34-bfc253ce2e78"),
                            IsPublic = false,
                            Name = "Lu Raise",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Shoulder",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("71b2ddf0-764b-4205-be57-276cbbde2ec6"),
                            IsPublic = false,
                            Name = "Pike Pushup",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Shoulder",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("dd0f6c20-5f08-43f4-bd62-7a75b8be9216"),
                            IsPublic = false,
                            Name = "Handstand",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Shoulder",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("6f50f6ac-080a-446b-a94d-bc722cb61c91"),
                            IsPublic = false,
                            Name = "Handstand Pushup",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Shoulder",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("03ba56df-38c1-4e22-a858-47448bfa760d"),
                            IsPublic = false,
                            Name = "Cable Row (Lats)",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Lat",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("ebe091e8-7741-41fd-8237-ab2ef1ef739b"),
                            IsPublic = false,
                            Name = "Cable Row (Upper Back)",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "UpperBack",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("9baa772a-0b1b-4497-b165-b85130a0079a"),
                            IsPublic = false,
                            Name = "Cable Chest Press (Upper)",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Chest",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("fb60e558-adcc-49c6-b23f-b82540b148b8"),
                            IsPublic = false,
                            Name = "Cable Chest Press (Middle)",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Chest",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("225d005b-165c-499d-845b-8a89ca119fd7"),
                            IsPublic = false,
                            Name = "Cable Chest Press (Lower)",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Chest",
                            Region = "Upper",
                            Type = "Strength"
                        },
                        new
                        {
                            Id = new Guid("3c156a82-4725-4684-9c24-c73bfd6da4c0"),
                            IsPublic = false,
                            Name = "Hip Adduction",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Hip",
                            Region = "Lower",
                            Type = "Mobility"
                        },
                        new
                        {
                            Id = new Guid("8abd1ae2-81cd-4d05-aabc-70fbff7eb815"),
                            IsPublic = false,
                            Name = "Hip Abduction",
                            Notes = "This is a default exericse",
                            PrimaryMuscle = "Hip",
                            Region = "Lower",
                            Type = "Mobility"
                        });
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.ExerciseSet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseSets");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.ProgramWorkouts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<Guid>("WorkoutId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WorkoutProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.HasIndex("WorkoutProgramId");

                    b.ToTable("ProgramWorkouts");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.Workout", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid>("ProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.HasIndex("UserId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.WorkoutProgram", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoverPhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("NumberOfDaysPerWeek")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfWeeks")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CoverPhotoId");

                    b.HasIndex("UserId");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NenWebApp.Web.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NenWebApp.Web.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NenWebApp.Web.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NenWebApp.Web.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.DetailedExercise", b =>
                {
                    b.HasOne("NenWebApp.Web.Entities.Exercise", "BaseInformation")
                        .WithMany("DetailedExercises")
                        .HasForeignKey("BaseInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NenWebApp.Web.Entities.Workout", "Workout")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BaseInformation");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.Exercise", b =>
                {
                    b.HasOne("NenWebApp.Web.Entities.ApplicationUser", "User")
                        .WithMany("Exercises")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.ExerciseSet", b =>
                {
                    b.HasOne("NenWebApp.Web.Entities.DetailedExercise", "Exercise")
                        .WithMany("ExerciseSets")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.ProgramWorkouts", b =>
                {
                    b.HasOne("NenWebApp.Web.Entities.Workout", "Workout")
                        .WithMany()
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NenWebApp.Web.Entities.WorkoutProgram", null)
                        .WithMany("Workouts")
                        .HasForeignKey("WorkoutProgramId");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.Workout", b =>
                {
                    b.HasOne("NenWebApp.Web.Entities.WorkoutProgram", "Program")
                        .WithMany()
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NenWebApp.Web.Entities.ApplicationUser", "User")
                        .WithMany("Workouts")
                        .HasForeignKey("UserId");

                    b.Navigation("Program");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.WorkoutProgram", b =>
                {
                    b.HasOne("NenWebApp.Web.Entities.CoverPhoto", "CoverPhoto")
                        .WithMany("Programs")
                        .HasForeignKey("CoverPhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NenWebApp.Web.Entities.ApplicationUser", "User")
                        .WithMany("Programs")
                        .HasForeignKey("UserId");

                    b.Navigation("CoverPhoto");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.ApplicationUser", b =>
                {
                    b.Navigation("Exercises");

                    b.Navigation("Programs");

                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.CoverPhoto", b =>
                {
                    b.Navigation("Programs");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.DetailedExercise", b =>
                {
                    b.Navigation("ExerciseSets");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.Exercise", b =>
                {
                    b.Navigation("DetailedExercises");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.Workout", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("NenWebApp.Web.Entities.WorkoutProgram", b =>
                {
                    b.Navigation("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}