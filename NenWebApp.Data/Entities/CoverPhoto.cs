using System.ComponentModel.DataAnnotations;

namespace NenWebApp.Data.Entities;

public class CoverPhoto
{
    public Guid Id { get; set; }

    [StringLength(25)]
    public string Name { get; set; }
    public string Image { get; set; }

    public List<WorkoutProgram> Programs { get; set; }
}