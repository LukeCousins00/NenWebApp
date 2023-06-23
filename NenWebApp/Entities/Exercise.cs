using NenWebApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace NenWebApp.Entities;
public class Exercise
{
    public Guid Id { get; set; }

    [StringLength(30)]
    public string Name { get; set; } // REQUIRED
    public string Region { get; set; } // INFERRED FROM PRIMARY MUSCLE!!

    [StringLength(200)]
    public string? Notes { get; set; } // User notes on the exercise
    public string Type { get; set; } // REQUIRED
    public string PrimaryMuscle { get; set; }  // REQUIRED  // Main muscle trained during this exercise
    public bool IsPublic { get; set; }

    public ApplicationUser User { get; set; }
    public List<DetailedExercise> DetailedExercises { get; set;}
}