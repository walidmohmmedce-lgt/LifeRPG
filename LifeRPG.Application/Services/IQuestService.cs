using LifeRPG.Domain.Entities;

namespace LifeRPG.Application.Services;

public interface IQuestService
{
    Task CompleteQuestAsync(Guid userId, Guid questId);
}
