﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NenWebApp.Data;
using NenWebApp.Entities;
using NenWebApp.Interfaces;
using NenWebApp.ViewModels;
using System.Security.Claims;

namespace NenWebApp.Services;

public class DatabaseService : IDatabaseService
{
    private readonly AppDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public DatabaseService(AppDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;

    }

    public async Task DeleteExerciseEntryAsync(Guid id)
    {
        var entity = await _context.Set<Exercise>().FindAsync(id);
        if (entity != null)
        {
            if (entity.User != null)
            {
                _context.Set<Exercise>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }

    public IQueryable<ExerciseViewModel> GetExercises()
    {
        var exerciseQuery = _context.Exercises.Select(e => new ExerciseViewModel
        {
            Id = e.Id,
            Name = e.Name,
            Region = e.Region,
            IsPublic = e.IsPublic,
            Notes = e.Notes,
            PrimaryMuscle = e.PrimaryMuscle,
            Type = e.Type   
        });

        return exerciseQuery;
    } 

    public async Task AddExerciseAsync(ClaimsPrincipal user, ExerciseViewModel viewModel)
    {
        var userId = await _userManager.GetUserAsync(user);

        Exercise newExercise = new Exercise
        {
            Name = viewModel.Name,
            PrimaryMuscle = viewModel.PrimaryMuscle,
            Region = viewModel.Region,
            Type = viewModel.Type,
            Notes = viewModel.Notes,
            IsPublic = viewModel.IsPublic,
            User = userId
        };

        await _context.Exercises.AddAsync(newExercise);
        await _context.SaveChangesAsync();
    }

    public async Task EditExerciseAsync(ExerciseViewModel viewModel)
    {
        var entity = await _context.Set<Exercise>().FindAsync(viewModel.Id);
        if (entity != null)
        {
            entity.Region = viewModel.Region;
            entity.Type = viewModel.Type;
            entity.Notes = viewModel.Notes;
            entity.Name = viewModel.Name;
            entity.PrimaryMuscle = viewModel.PrimaryMuscle;
            entity.IsPublic = viewModel.IsPublic;
            
            await _context.SaveChangesAsync();
        }
    }
}
