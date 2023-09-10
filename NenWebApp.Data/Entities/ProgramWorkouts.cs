namespace NenWebApp.Data.Entities;

public class ProgramWorkouts
{
    public Guid Id { get; set; }
    public int Day { get; set; }
    
    public required Workout Workout { get; set; }
}