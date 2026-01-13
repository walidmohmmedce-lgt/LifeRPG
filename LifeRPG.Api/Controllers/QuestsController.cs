using LifeRPG.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace LifeRPG.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestsController : ControllerBase
{
    private readonly IQuestService _questService;

    public QuestsController(IQuestService questService)
    {
        _questService = questService;
    }

    // POST: /api/quests/complete
    [HttpPost("complete")]
public async Task<IActionResult> CompleteQuest(Guid userId, Guid questId)
{
    try
    {
        await _questService.CompleteQuestAsync(userId, questId);
        return Ok("Quest completed. XP updated.");
    }
    catch (Exception ex)
    {
        return BadRequest(ex.Message);
    }
}

}
