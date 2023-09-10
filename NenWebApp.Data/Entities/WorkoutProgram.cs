using System.ComponentModel.DataAnnotations;

namespace NenWebApp.Data.Entities;
public class WorkoutProgram
{
    public Guid Id { get; set; }

    [StringLength(30)]
    public string Name { get; set; }
    public int NumberOfWeeks { get; set; }
    public int NumberOfDaysPerWeek { get; set; }
    public bool IsActive { get; set; }  
    public bool IsPublic { get; set; }

    public List<ProgramWorkouts> Workouts { get; set; }
    public ApplicationUser User { get; set; }
    public CoverPhoto CoverPhoto { get; set; }
}