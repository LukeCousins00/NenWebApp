using System.Security.Claims;
using NenWebApp.Shared.DTOs;

namespace NenWebApp.Logic.Interfaces;

public interface IExerciseService 
{
    Task<IQueryable<ExerciseDto>?> GetExercises(ClaimsPrincipal user);
    Task DeleteExerciseEntryAsync(ClaimsPrincipal user, Guid exerciseId);
    Task AddOrEditExerciseAsync(ClaimsPrincipal user, ExerciseDto exercise);
}
