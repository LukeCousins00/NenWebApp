using Microsoft.AspNetCore.Mvc;
using NenWebApp.Models;

namespace NenWebApp.ViewComponents;

public class WorkoutExerciseRowViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ExerciseButtonModel exercise)
    {
        return View(exercise);
    }
}