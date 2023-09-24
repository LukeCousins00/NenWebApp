using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using NenWebApp.Data;
using NenWebApp.Data.Entities;
using NenWebApp.Logic.Interfaces;
using NenWebApp.Shared.DTOs;

namespace NenWebApp.Logic.Services;

public class ActivityService : IActivityService
{
    private readonly AppDbContext _dbContext;
    private readonly UserManager<ApplicationUser?> _userManager;

    public ActivityService(AppDbContext dbContext, UserManager<ApplicationUser?> userManager)
    {
        _dbContext = dbContext;
        _userManager = userManager;
    }
    
    public async Task<IQueryable<ExerciseDto>?> GetExercises(ClaimsPrincipal user)
    {
        ApplicationUser? userId = await _userManager.GetUserAsync(user);

        if (userId == null)
            return null;

        ApplicationUser defaultUser = new ApplicationUser { Id = null };

        IQueryable<ExerciseDto>? exerciseQuery = _dbContext.Exercises
            .Where(e => e.User == userId || e.User == defaultUser)
            .OrderBy(e => e.Name)
            .Select(e => new ExerciseDto
            {
                Id = e.Id,
                Name = e.Name,
                IsPublic = e.IsPublic,
                Notes = e.Notes,
                Category = e.Category,
                Anatomy = new AnatomyDto
                {
                    Id = e.Anatomy.Id,
                    Name = e.Anatomy.Name,
                    Category = e.Anatomy.Category,
                    Section = e.Anatomy.Section,
                    BodyPart = e.Anatomy.BodyPart
                }
            });

        return exerciseQuery;
    }

    public async Task DeleteExerciseEntryAsync(ClaimsPrincipal user, Guid exerciseId)
    {
        ApplicationUser? userId = await _userManager.GetUserAsync(user);

        if (userId == null)
            return;

        var entity = _dbContext.Exercises.FirstOrDefault(e => e.User == userId && e.Id == exerciseId);
        if (entity != null)
        {
            _dbContext.Exercises.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task AddOrEditExerciseAsync(ClaimsPrincipal user, ExerciseDto exercise)
    {
        ApplicationUser? userId = await _userManager.GetUserAsync(user);

        if (userId == null)
            return;

        if (!exercise.Id.ToString().IsNullOrEmpty())
        {
            Exercise? entity = _dbContext.Exercises.FirstOrDefault(e => e.User == userId && e.Id == exercise.Id);
            
            if (entity != null)
            {
                entity.Notes = exercise.Notes;
                entity.Name = exercise.Name;
                entity.IsPublic = exercise.IsPublic;
                entity.Anatomy = new Anatomy
                {
                    Id = exercise.Anatomy.Id,
                    Name = exercise.Anatomy.Name,
                    Category = exercise.Anatomy.Category,
                    Section = exercise.Anatomy.Section,
                    BodyPart = exercise.Anatomy.BodyPart
                };
                entity.Category = exercise.Category;

                await _dbContext.SaveChangesAsync();
                return;
            }

            return;
        }

        var newExercise = new Exercise
        {
            Name = exercise.Name,
            Category = exercise.Category,
            Notes = exercise.Notes,
            IsPublic = exercise.IsPublic,
            User = userId,
            Anatomy = new Anatomy
            {
                Id = exercise.Anatomy.Id,
                Name = exercise.Anatomy.Name,
                Category = exercise.Anatomy.Category,
                Section = exercise.Anatomy.Section,
                BodyPart = exercise.Anatomy.BodyPart
            }
        };

        await _dbContext.Exercises.AddAsync(newExercise);
        await _dbContext.SaveChangesAsync();
    }
}