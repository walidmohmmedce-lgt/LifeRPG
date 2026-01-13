namespace LifeRPG.Domain.Entities;

public class Quest
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int XPReward { get; set; }

    public int RequiredLevel { get; set; }

    public bool IsDaily { get; set; }
}
