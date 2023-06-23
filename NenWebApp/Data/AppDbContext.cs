using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NenWebApp.Entities;
using NenWebApp.Enums;

namespace NenWebApp.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<CoverPhoto> CoverPhoto { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<DetailedExercise> DetailedExercises { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<ExerciseSet> Sets { get; set; }
    public DbSet<WorkoutProgram> Programs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Pull Up",
            IsPublic = false,
            PrimaryMuscle = Muscle.Lat.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Lat Pulldown",
            IsPublic = false,
            PrimaryMuscle = Muscle.Lat.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Pulldown (Upper Back)",
            IsPublic = false,
            PrimaryMuscle = Muscle.UpperBack.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Push Up",
            IsPublic = false,
            PrimaryMuscle = Muscle.Chest.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });


        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Leg Press",
            IsPublic = false,
            PrimaryMuscle = Muscle.Quad.ToString(),
            Region = MuscleRegion.Lower.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });


        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Incline Dumbell Curl",
            IsPublic = false,
            PrimaryMuscle = Muscle.Bicep.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Decline Dumbell Curl",
            IsPublic = false,
            PrimaryMuscle = Muscle.Bicep.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Dip (Chest)",
            IsPublic = false,
            PrimaryMuscle = Muscle.Chest.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Dip (Forearms)",
            IsPublic = false,
            PrimaryMuscle = Muscle.Forearm.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Wrist Curl",
            IsPublic = false,
            PrimaryMuscle = Muscle.Forearm.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Leg Curl",
            IsPublic = false,
            PrimaryMuscle = Muscle.Hamstring.ToString(),
            Region = MuscleRegion.Lower.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Butterfly Curl",
            IsPublic = false,
            PrimaryMuscle = Muscle.Hamstring.ToString(),
            Region = MuscleRegion.Lower.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Overhead Press",
            IsPublic = false,
            PrimaryMuscle = Muscle.Shoulder.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Barbell Bench Press",
            IsPublic = false,
            PrimaryMuscle = Muscle.Chest.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Dumbell Bench Press",
            IsPublic = false,
            PrimaryMuscle = Muscle.Chest.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "High Row",
            IsPublic = false,
            PrimaryMuscle = Muscle.Lat.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "45 Degree Hyperextension",
            IsPublic = false,
            PrimaryMuscle = Muscle.Glutes.ToString(),
            Region = MuscleRegion.Lower.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Tricep Pushdown",
            IsPublic = false,
            PrimaryMuscle = Muscle.Tricep.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Lu Raise",
            IsPublic = false,
            PrimaryMuscle = Muscle.Shoulder.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Pike Pushup",
            IsPublic = false,
            PrimaryMuscle = Muscle.Shoulder.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Handstand",
            IsPublic = false,
            PrimaryMuscle = Muscle.Shoulder.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Handstand Pushup",
            IsPublic = false,
            PrimaryMuscle = Muscle.Shoulder.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Cable Row (Lats)",
            IsPublic = false,
            PrimaryMuscle = Muscle.Lat.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Cable Row (Upper Back)",
            IsPublic = false,
            PrimaryMuscle = Muscle.UpperBack.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Cable Chest Press (Upper)",
            IsPublic = false,
            PrimaryMuscle = Muscle.Chest.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Cable Chest Press (Middle)",
            IsPublic = false,
            PrimaryMuscle = Muscle.Chest.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Cable Chest Press (Lower)",
            IsPublic = false,
            PrimaryMuscle = Muscle.Chest.ToString(),
            Region = MuscleRegion.Upper.ToString(),
            Type = ExerciseType.Strength.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Hip Adduction",
            IsPublic = false,
            PrimaryMuscle = Muscle.Hip.ToString(),
            Region = MuscleRegion.Lower.ToString(),
            Type = ExerciseType.Mobility.ToString(),
            Notes = "This is a default exericse",
        });

        builder.Entity<Exercise>().HasData(new Exercise
        {
            Id = Guid.NewGuid(),
            Name = "Hip Abduction",
            IsPublic = false,
            PrimaryMuscle = Muscle.Hip.ToString(),
            Region = MuscleRegion.Lower.ToString(),
            Type = ExerciseType.Mobility.ToString(),
            Notes = "This is a default exericse",
        });

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
    }
}