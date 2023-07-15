using Microsoft.AspNetCore.Mvc;
using NenWebApp.Interfaces;
using NenWebApp.ViewModels;
using NenWebApp.Enums;

namespace NenWebApp.Controllers;
public class CollectionController : Controller
{

    private readonly IDatabaseService _databaseService;

    public CollectionController(IDatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddNewExercise(ExerciseViewModel newExercise)
    {
        await _databaseService.AddExerciseAsync(User, newExercise);

        var viewModel = _databaseService.GetExercises();
        return View("Exercises", viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteExerciseEntry(string id)
    {
        Guid exerciseId = Guid.Parse(id);
        await _databaseService.DeleteExerciseEntryAsync(exerciseId);

        var viewModel = _databaseService.GetExercises();
        return View("Exercises", viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> EditExerciseEntry(ExerciseViewModel editedExercise)
    {
        await _databaseService.EditExerciseAsync(editedExercise);

        var viewModel = _databaseService.GetExercises();
        return View("Exercises", viewModel);
    }

    public IActionResult Exercises()
    {
        var viewModel = _databaseService.GetExercises();

        return View("Exercises", viewModel);
    }

    public IActionResult GetMusclesByRegion(string region)
    {
        List<string> regionMatchedMuscles = MuscleRegionMapping.GetMusclesForRegion(region);

        return Json(regionMatchedMuscles);
    }
}