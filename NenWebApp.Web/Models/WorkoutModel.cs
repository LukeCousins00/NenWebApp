namespace NenWebApp.Models;

public class WorkoutModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool IsPublic { get; set; } = false;

    public List<DetailedExerciseModel> Exercises { get; set; }
}