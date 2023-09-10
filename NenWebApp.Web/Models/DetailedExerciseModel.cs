namespace NenWebApp.Models;

public class DetailedExerciseModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Notes { get; set; }
    public int Sets { get; set; }
    public int LowReps { get; set; }
    public int HighReps { get; set; }
    public int Rest { get; set; } = 60; // Rest time in seconds between sets
}