using System.ComponentModel.DataAnnotations;
using NenWebApp.Shared.Enums;

namespace NenWebApp.Data.Entities;
public class Exercise
{
    public Guid Id { get; set; }

    [StringLength(30)]
    public required string Name { get; set; } // REQUIRED

    [StringLength(200)]
    public string? Notes { get; set; } // User notes on the exercise
    public ExerciseCategory Category { get; set; } // REQUIRED
    public required Anatomy Anatomy { get; set; }  // REQUIRED  // Main body part trained during this exercise
    public bool IsPublic { get; set; }

    public required ApplicationUser User { get; set; }
    public List<DetailedExercise>? DetailedExercises { get; set;}
}