using Microsoft.AspNetCore.Mvc.RazorPages;
using NenWebApp.Logic.Interfaces;
using NenWebApp.Shared.DTOs;
using NenWebApp.ViewModels;

namespace NenWebApp.Pages;

public class Exercises : PageModel
{
    private readonly IExerciseService _exerciseService;
    
    public IQueryable<ExerciseDto>? ExerciseList { get; set; }
    public int? ExerciseId { get; set; }

    public Exercises(IExerciseService exerciseService)
    {
        _exerciseService = exerciseService;
    }
    
    public async void OnGetAsync()
    {
        ExerciseList = await _exerciseService.GetExercises(User);
    }

    public void OnPost()
    {
        
    }
}