using Microsoft.AspNetCore.Mvc.RazorPages;
using NenWebApp.Logic.Interfaces;
using NenWebApp.Shared.DTOs;

namespace NenWebApp.Pages;

public class Exercises : PageModel
{
    private readonly IActivityService _activityService;
    
    public IQueryable<ExerciseDto>? ExerciseList { get; set; }
    public int? Id { get; set; }

    public Exercises(IActivityService activityService)
    {
        _activityService = activityService;
    }
    
    public async void OnGetAsync()
    {
        ExerciseList = await _activityService.GetExercises(User);
    }

    public void OnPost()
    {
        
    }

    public async Task OnPostDeleteAsync()
    {
        
    }
}