﻿using Microsoft.AspNetCore.Identity;

namespace NenWebApp.Data.Entities;
public class ApplicationUser : IdentityUser
{
    public List<Exercise>? Exercises { get; set; } // Would like to have a predefined set of Exercises already created which will be present when a user creates an account
    public List<Workout>? Workouts { get; set; }
    public List<WorkoutProgram>? Programs { get; set; }

    public bool IsPublic { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
}