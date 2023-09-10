using NenWebApp.Models;

namespace NenWebApp.ViewModels;

public class WorkoutViewModel
{
    public List<WorkoutModel> Workouts { get; set; }
    public List<ExerciseButtonModel> AllUserExercises { get; set; }
}