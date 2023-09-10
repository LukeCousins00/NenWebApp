using NenWebApp.Shared.Enums;

namespace NenWebApp.Shared.DTOs;

public class AnatomyDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public Section Section { get; set; }
    public AnatomyCategory Category { get; set; }
    public BodyPart BodyPart { get; set; }
}