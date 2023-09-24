// using Microsoft.AspNetCore.Mvc;
// using NenWebApp.Logic.Interfaces;
// using NenWebApp.Shared.DTOs;
// using NenWebApp.Shared.Enums;
// using NenWebApp.Shared.Mapping;
// using NenWebApp.ViewModels;
//
// namespace NenWebApp.Controllers;
// public class ExerciseController : Controller
// {
//     private readonly IActivityService _activityService;
//
//     public ExerciseController(IActivityService activityService)
//     {
//         _activityService = activityService;
//     }
//     
//     public IActionResult Index()
//     {
//         var viewModel = _activityService.GetExercises(User).Result;
//         return View(viewModel);
//     }
//     
//     [HttpPost]
//     public async Task<IActionResult> DeleteExerciseEntry(string id)
//     {
//         await _activityService.DeleteExerciseEntryAsync(User, Guid.Parse(id));
//
//         var viewModel = _activityService.GetExercises(User).Result;
//         return View("Index", viewModel);
//     }
//
//     [HttpPost]
//     public async Task<IActionResult> AddOrEditExerciseEntry(ExerciseViewModel editedExercise)
//     {
//         await _activityService.AddOrEditExerciseAsync(User, editedExercise);
//
//         var viewModel = _activityService.GetExercises(User).Result;
//         return View("Index", viewModel);
//     }
//
//     public IActionResult GetMusclesByRegion(string region)
//     {
//         List<string> regionMatchedMuscles = MuscleRegionMapping.GetMusclesForRegion(region);
//
//         return Json(regionMatchedMuscles);
//     }
// }