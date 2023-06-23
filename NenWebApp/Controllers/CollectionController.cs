using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NenWebApp.Data;
using NenWebApp.Entities;
using NenWebApp.Interfaces;
using NenWebApp.ViewModels;

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
        var viewModel = _databaseService.GetExercises();

        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> AddNewExercise(ExerciseViewModel newExercise)
    {
        await _databaseService.AddExerciseAsync(User, newExercise);

        var viewModel = _databaseService.GetExercises();
        return View("Index", viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteExerciseEntry(string id)
    {
        Guid exerciseId = Guid.Parse(id);
        await _databaseService.DeleteExerciseEntryAsync(exerciseId);

        var viewModel = _databaseService.GetExercises();
        return View("Index", viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> EditExerciseEntry(ExerciseViewModel editedExercise)
    {
        await _databaseService.EditExerciseAsync(editedExercise);

        var viewModel = _databaseService.GetExercises();
        return View("Index", viewModel);
    }
}