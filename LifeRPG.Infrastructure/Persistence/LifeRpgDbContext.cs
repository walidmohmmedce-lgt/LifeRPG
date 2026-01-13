using LifeRPG.Application.Common;
using LifeRPG.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LifeRPG.Infrastructure.Persistence;

public class LifeRpgDbContext : DbContext, IApplicationDbContext
{
    public LifeRpgDbContext(DbContextOptions<LifeRpgDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Quest> Quests => Set<Quest>();
    public DbSet<QuestCompletion> QuestCompletions => Set<QuestCompletion>();
    public DbSet<Achievement> Achievements => Set<Achievement>();
    public DbSet<UserAchievement> UserAchievements => Set<UserAchievement>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserAchievement>()
            .HasKey(ua => new { ua.UserId, ua.AchievementId });

        base.OnModelCreating(modelBuilder);
    }
}
