using System.ComponentModel.DataAnnotations;

namespace NenWebApp.Data.Entities;

public class Workout
{
    public Guid Id { get; set; }
    
    [StringLength(30)]
    public string Name { get; set; }
    public bool IsPublic { get; set; } = false;
    
    public ApplicationUser User { get; set; }
    public List<DetailedExercise> Exercises { get; set; }
    public WorkoutProgram Program { get; set; }
}