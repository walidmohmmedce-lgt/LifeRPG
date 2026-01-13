namespace LifeRPG.Domain.Entities;

public class QuestCompletion
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid QuestId { get; set; }

    public DateTime CompletedAt { get; set; } = DateTime.UtcNow;
}