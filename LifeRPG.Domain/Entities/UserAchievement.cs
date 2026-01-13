namespace LifeRPG.Domain.Entities;

public class UserAchievement
{
    public Guid UserId { get; set; }

    public Guid AchievementId { get; set; }

    public DateTime UnlockedAt { get; set; } = DateTime.UtcNow;
}
