using LifeRPG.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LifeRPG.Application.Common;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<Quest> Quests { get; }
    DbSet<QuestCompletion> QuestCompletions { get; }
    DbSet<Achievement> Achievements { get; }
    DbSet<UserAchievement> UserAchievements { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
