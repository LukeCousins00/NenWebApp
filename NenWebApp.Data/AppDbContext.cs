using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NenWebApp.Data.Entities;
using NenWebApp.Shared.Enums;

namespace NenWebApp.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<CoverPhoto> CoverPhoto { get; set; }

    public DbSet<Anatomy> Anatomies { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<DetailedExercise> DetailedExercises { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<ExerciseSet> ExerciseSets { get; set; }
    public DbSet<WorkoutProgram> Programs { get; set; }
    public DbSet<ProgramWorkouts> ProgramWorkouts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Forearm",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Arms
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Bicep",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Arms
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Tricep",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Arms
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Chest",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Torso
        });

        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Upper Back",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Torso
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Lower Back",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Torso
        });

        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Shoulder",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Arms
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Hamstring",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Legs
        });

        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Calf",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Legs
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Quad",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Legs
        });

        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Abdominal Oblique",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Torso
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Rectus Abdominis",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Torso
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Tibialis",
            Section = Section.Upper,
            Category = AnatomyCategory.Tendon,
            BodyPart = BodyPart.Legs
        });

        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Hip",
            Section = Section.Upper,
            Category = AnatomyCategory.Joint,
            BodyPart = BodyPart.Legs
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Wrist",
            Section = Section.Upper,
            Category = AnatomyCategory.Joint,
            BodyPart = BodyPart.Arms
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Ankle",
            Section = Section.Upper,
            Category = AnatomyCategory.Joint,
            BodyPart = BodyPart.Legs
        });
        
        builder.Entity<Anatomy>().HasData(new Anatomy
        {
            Id = Guid.NewGuid(),
            Name = "Glute",
            Section = Section.Upper,
            Category = AnatomyCategory.Muscle,
            BodyPart = BodyPart.Legs
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