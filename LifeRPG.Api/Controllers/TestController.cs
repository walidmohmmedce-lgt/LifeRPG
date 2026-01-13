using LifeRPG.Application.Common;
using LifeRPG.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LifeRPG.Api.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private readonly IApplicationDbContext _context;

    public TestController(IApplicationDbContext context)
    {
        _context = context;
    }

    // POST: api/test/create-quest
    [HttpPost("create-quest")]
    public async Task<IActionResult> CreateQuest()
    {
        var quest = new Quest
        {
            Id = Guid.NewGuid(),
            Title = "First Quest",
            Description = "Complete your first quest",
            XPReward = 120,
            RequiredLevel = 1,
            IsDaily = false
        };

        _context.Quests.Add(quest);
        await _context.SaveChangesAsync();

        return Ok(quest);
    }

    // POST: api/test/create-achievement
[HttpPost("create-achievement")]
public async Task<IActionResult> CreateAchievement(int requiredLevel)
{
    var achievement = new Achievement
    {
        Id = Guid.NewGuid(),
        Name = $"Reach Level {requiredLevel}",
        Description = $"Unlocked when user reaches level {requiredLevel}",
        RequiredLevel = requiredLevel
    };

    _context.Achievements.Add(achievement);
    await _context.SaveChangesAsync();

    return Ok(achievement);
}

}
