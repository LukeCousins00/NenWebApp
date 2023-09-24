// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;
// using NenWebApp.Data;
// using NenWebApp.Data.Entities;
// using NenWebApp.Logic.Interfaces;
// using NenWebApp.Models;
// using NenWebApp.ViewModels;
//
// namespace NenWebApp.Controllers;
//
// public class WorkoutController : Controller
// {
//     private readonly UserManager<ApplicationUser> _userManager;
//     private readonly AppDbContext _dbContext;
//     private readonly IActivityService _activityService;
//
//     public WorkoutController(UserManager<ApplicationUser> userManager, AppDbContext dbContext,
//         IActivityService activityService)
//     {
//         _dbContext = dbContext;
//         _userManager = userManager;
//         _activityService = activityService;
//     }
//
//     public async Task<WorkoutViewModel?> GetWorkoutViewModel()
//     {
//         ApplicationUser? userId = await _userManager.GetUserAsync(User);
//         if (userId == null)
//             return null;
//         
//         ApplicationUser defaultUser = new ApplicationUser { Id = "" };
//
//         IEnumerable<Workout> userWorkouts = _dbContext.Workouts.Where(w => w.User == userId || w.User == defaultUser).OrderBy(w => w.Name);
//         List<WorkoutModel> workouts = userWorkouts
//             .Select(w => new WorkoutModel()
//             {
//                 Name = w.Name,
//                 IsPublic = w.IsPublic,
//                 Exercises = w.Exercises.Select(e => new DetailedExerciseModel()
//                 {
//                     Id = e.Id,
//                     Rest = e.Rest,
//                     Sets = e.Sets,
//                     HighReps = e.HighReps,
//                     LowReps = e.LowReps,
//                     Name = e.BaseInformation.Name,
//                     Notes = e.BaseInformation.Notes
//                 }).ToList()
//             }).ToList();
//
//         IQueryable<ExerciseViewModel> exercises =  _activityService.GetExercises(User).Result;
//         List<ExerciseButtonModel> allUserExercises = exercises.Select(e => new ExerciseButtonModel()
//         {
//             Id = e.Id,
//             Name = e.Name,
//             Notes = e.Notes
//         }).ToList();
//
//         WorkoutViewModel workoutViewModel = new WorkoutViewModel()
//         {
//             Workouts = workouts,
//             AllUserExercises = allUserExercises
//         };
//
//         return workoutViewModel;
//     }
//     
//     public async Task<IActionResult> Index()
//     {
//         WorkoutViewModel? viewModel = await GetWorkoutViewModel();
//
//         if (viewModel != null)
//         {
//             return View("Index", viewModel);
//         }
//
//         return View();
//     }
//     
//     public async Task<IActionResult> Builder()
//     {
//         WorkoutViewModel? viewModel = await GetWorkoutViewModel();
//
//         if (viewModel != null)
//         {
//             return View("Builder", viewModel);
//         }
//
//         return View("Index");
//     }
//
//     public IActionResult AddExerciseViewComponent(string exercise)
//     {
//         return ViewComponent("WorkoutExerciseRow", exercise);
//     }
//
//     public async Task<IActionResult> SaveWorkout()
//     {
//         return View("Index");
//     }
// }