using System.ComponentModel.DataAnnotations;
using NenWebApp.Shared.Enums;

namespace NenWebApp.Shared.DTOs;

public class ExerciseDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public bool IsPublic { get; set; }
    public ExerciseCategory Category { get; set; } // REQUIRED
    public required AnatomyDto Anatomy { get; set; }  // REQUIRED  // Main muscle trained during this exercise

    [StringLength(200)]
    public string? Notes { get; set; } // User notes on the exercise
}