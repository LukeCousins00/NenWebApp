using NenWebApp.ViewModels;
using System.Security.Claims;

namespace NenWebApp.Interfaces;

public interface IDatabaseService 
{
    IQueryable<ExerciseViewModel> GetExercises();
    Task AddExerciseAsync(ClaimsPrincipal user, ExerciseViewModel viewModel);
    Task DeleteExerciseEntryAsync(Guid id);
    Task EditExerciseAsync(ExerciseViewModel viewModel);
}
