using Microsoft.AspNetCore.Mvc;
using NenWebApp.Logic.Interfaces;
using NenWebApp.Shared.DTOs;
using NenWebApp.Shared.Enums;
using NenWebApp.Shared.Mapping;
using NenWebApp.ViewModels;

namespace NenWebApp.Controllers;
public class ExerciseController : Controller
{
    private readonly IExerciseService _exerciseService;

    public ExerciseController(IExerciseService exerciseService)
    {
        _exerciseService = exerciseService;
    }
    
    public IActionResult Index()
    {
        var viewModel = _exerciseService.GetExercises(User).Result;
        return View(viewModel);
    }
    
    [HttpPost]
    public async Task<IActionResult> DeleteExerciseEntry(string id)
    {
        await _exerciseService.DeleteExerciseEntryAsync(User, Guid.Parse(id));

        var viewModel = _exerciseService.GetExercises(User).Result;
        return View("Index", viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> AddOrEditExerciseEntry(ExerciseViewModel editedExercise)
    {
        await _exerciseService.AddOrEditExerciseAsync(User, editedExercise);

        var viewModel = _exerciseService.GetExercises(User).Result;
        return View("Index", viewModel);
    }

    public IActionResult GetMusclesByRegion(string region)
    {
        List<string> regionMatchedMuscles = MuscleRegionMapping.GetMusclesForRegion(region);

        return Json(regionMatchedMuscles);
    }
}