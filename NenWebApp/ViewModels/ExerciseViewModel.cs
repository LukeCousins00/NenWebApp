using NenWebApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace NenWebApp.ViewModels;

public class ExerciseViewModel
{
    public string Region { get; set; }
    public string Name { get; set; }
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? Notes { get; set; } // User notes on the exercise
    public string Type { get; set; } // REQUIRED
    public string PrimaryMuscle { get; set; }  // REQUIRED  // Main muscle trained during this exercise
    public bool IsPublic { get; set; }
    public List<Muscle> MusclesByRegion { get; set; }
}