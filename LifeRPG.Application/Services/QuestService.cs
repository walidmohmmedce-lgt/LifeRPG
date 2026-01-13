using LifeRPG.Application.Common;
using LifeRPG.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LifeRPG.Application.Services;

public class QuestService : IQuestService
{
    private readonly IApplicationDbContext _context;

    public QuestService(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CompleteQuestAsync(Guid userId, Guid questId)
    {
        // 1. Find user
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null)
            throw new Exception("User not found");

        // 2. Find quest
        var quest = await _context.Quests
            .FirstOrDefaultAsync(q => q.Id == questId);

        if (quest == null)
            throw new Exception("Quest not found");

        // 3. Check if quest already completed
        var alreadyCompleted = await _context.QuestCompletions
            .AnyAsync(qc => qc.UserId == userId && qc.QuestId == questId);

        if (alreadyCompleted)
            throw new Exception("You have already completed this quest.");

        // 4. Save quest completion
        var completion = new QuestCompletion
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            QuestId = questId,
            CompletedAt = DateTime.UtcNow
        };

        _context.QuestCompletions.Add(completion);

        // 5. Add XP to user
        user.XP += quest.XPReward;

        // 6. Simple level-up rule
        // Every 100 XP = +1 level
        var newLevel = (user.XP / 100) + 1;
        user.Level = newLevel;

        // 7. Unlock achievements based on level
        var achievementsToUnlock = await _context.Achievements
            .Where(a => a.RequiredLevel <= user.Level)
            .ToListAsync();

        foreach (var achievement in achievementsToUnlock)
        {
            var alreadyUnlocked = await _context.UserAchievements
                .AnyAsync(ua => ua.UserId == user.Id && ua.AchievementId == achievement.Id);

            if (!alreadyUnlocked)
            {
                _context.UserAchievements.Add(new UserAchievement
                {
                    UserId = user.Id,
                    AchievementId = achievement.Id,
                    UnlockedAt = DateTime.UtcNow
                });
            }
        }

        await _context.SaveChangesAsync();
    }
}
