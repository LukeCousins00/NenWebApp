namespace NenWebApp.Data.Entities;

public class ExerciseSet
{
    public Guid Id { get; set; }
    public int Weight { get; set; }
    public int Reps { get; set; }
    
    public required DetailedExercise Exercise { get; set; }
}