using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NenWebApp.Data;

namespace NenWebApp.Entities;
public class WorkoutProgram
{
    public Guid Id { get; set; }

    [StringLength(30)]
    public string Name { get; set; }
    public int NumberOfWeeks { get; set; }
    public bool IsActive { get; set; }  
    public bool IsPublic { get; set; }

    public List<Workout> Workouts { get; set; }
    public ApplicationUser User { get; set; }
    public CoverPhoto CoverPhoto { get; set; }
}