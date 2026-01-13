namespace LifeRPG.Domain.Entities;

public class Achievement
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    // Example: "Reach Level 5"
    public int RequiredLevel { get; set; }
}
